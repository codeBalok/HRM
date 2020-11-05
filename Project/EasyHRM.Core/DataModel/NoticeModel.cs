﻿using EasyHRM.Core.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    public class NoticeModel : BaseModel
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
        
    }
}
