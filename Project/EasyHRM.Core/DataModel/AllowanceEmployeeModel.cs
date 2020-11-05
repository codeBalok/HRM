using EasyHRM.Core.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    public class AllowanceEmployeeModel : BaseModel
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }

        [ForeignKey("Allowance")]
        public int AllowanceId { get; set; }
        public AllowanceModel Allowance{ get; set; }
    }
}
