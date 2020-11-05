﻿using EasyHRM.Core.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    public class AllowanceTypeModel : BaseModel
    {
        [Required]
        [DisplayName("Allowance Type Name")]
        public string AllowanceTypeName { get; set; }
    }
}
