using EasyHRM.Core.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    public class LeaveTypeModel : BaseModel
    {
        [Required]
        [DisplayName("Leave Type Name")]
        public string LeaveTypeName { get; set; }
    }
}
