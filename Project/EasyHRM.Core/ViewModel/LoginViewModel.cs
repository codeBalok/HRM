using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.ViewModel
{
    public class LoginViewModel
    {
        //[Required]
        [EmailAddress]
        public string Email { get; set; }
        //[Required]
        public string Password { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string EduDashManagerID { get; set; }
    }
}
