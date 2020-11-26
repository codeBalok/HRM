using EasyHRM.Core.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    public class UserModel : BaseModel 
    {
        [EmailAddress]
        //[Required]
        public string Email { get; set; }
        //[Required]
        public string Password { get; set; }
        //[Required]
        public string Role { get; set; }
        [Required]
        public string UserIdDetail { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
