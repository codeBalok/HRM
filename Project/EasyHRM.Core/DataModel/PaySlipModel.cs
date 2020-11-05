using EasyHRM.Core.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    public class PaySlipModel : BaseModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required]
        public string Month { get; set; }
        [Required]
        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }
        public String Description { get; set; }
    }
}
