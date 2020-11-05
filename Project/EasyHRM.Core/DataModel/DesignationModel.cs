using EasyHRM.Core.DataModel.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyHRM.Core.DataModel
{
    [Table("Designation")]
    public class DesignationModel : BaseModel
    {
        [Required]
        [Remote("DesgExists", "Common", HttpMethod ="POST", ErrorMessage ="Name Already exists")]
        public string Name { get; set; }

        [ForeignKey("DepertmentModel")]
        [DisplayName("Depertment")]
        public int DepertmentId { get; set; }
        public DepartmentModel DepertmentModel { get; set; }
    }
}
