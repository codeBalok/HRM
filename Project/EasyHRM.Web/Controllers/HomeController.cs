using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyHRM.Web.Models;
using EasyHRM.Core.ViewModel;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using EasyHRM.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace EasyHRM.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository;

        public HomeController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        [AllowAnonymous]
        [Route("Home/Login")]
        public ActionResult Login(LoginViewModel model)
        {
            bool isUservalid = false;
            //var user = userRepository.All()
            //    .SingleOrDefault(x=>x.UserId == model.UserId);

            var user = model.UserId;

            if (user != null)
            {
                isUservalid = true;
            }


            if (isUservalid)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, user));

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    principal, props).Wait();
                //var url = "http://localhost:50451/Admin/Index";
                if (user != null)
                    return Json(new { newUrl = Url.Action("Index", "Admin") });
                //if (user.Role == "User")
                //    return RedirectToAction("Index", "Employee");
            }
            else
            {
                TempData["FFMsg"] = "Invalid Email or Password!";
            }

            return View();
        }

        //public ActionResult Login(LoginViewModel model)
        //{
        //    bool isUservalid = false;

        //    var user = userRepository.All()
        //        .SingleOrDefault(x=>x.Email == model.Email && x.Password == model.Password);

        //    if (user != null)
        //    {
        //        isUservalid = true;
        //    }


        //    if (ModelState.IsValid && isUservalid)
        //    {
        //        var claims = new List<Claim>();

        //        claims.Add(new Claim(ClaimTypes.Name, user.Email));

        //        string[] roles = user.Role.Split(",");

        //        foreach (string role in roles)
        //        {
        //            claims.Add(new Claim(ClaimTypes.Role, role));
        //        }

        //        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults. AuthenticationScheme);
        //        var principal = new ClaimsPrincipal(identity);

        //        var props = new AuthenticationProperties();
        //        //props.IsPersistent = model.RememberMe;

        //        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
        //            principal, props).Wait();
        //        if (user.Role == "Admin")
        //            return RedirectToAction("Index", "admin");
        //        if (user.Role == "User")
        //            return RedirectToAction("Index", "Employee");
        //    }
        //    else
        //    {
        //        TempData["FFMsg"] = "Invalid Email or Password!";
        //    }

        //    return View();
        //}

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index", "Home");
        }




    }
}
