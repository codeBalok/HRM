using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EasyHRM.Core.Interfaces;
using EasyHRM.Core.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyHRM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet]
        [Route("Login")]
        public ActionResult Login(string email, string password)
        {
            LoginViewModel model = new LoginViewModel
            {
                Email = email,
                Password = password
            };
            bool isUservalid = false;
            string returnPath = string.Empty;

            var user = userRepository.All()
                .SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            if (user != null)
            {
                isUservalid = true;
            }


            if (ModelState.IsValid && isUservalid)
            {
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Name, user.Email));

                string[] roles = user.Role.Split(",");

                foreach (string role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();
                //props.IsPersistent = model.RememberMe;

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
                if (user.Role == "Admin")
                    returnPath = "Index/admin";
                if (user.Role == "User")
                    returnPath = "Index/Employee";
            }
            else
            {
                //TempData["FFMsg"] = "Invalid Email or Password!";
            }

            return Ok(returnPath);
        }
    }
}
