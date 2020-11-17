using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyHRM.Core.ViewModel
{
    public class AttendenceViewModel
    {
        public AttendenceViewModel()
        {
            AttendenceListViewModel = new Collection<AttendenceListViewModel>();
            AttendenceDate = DateTime.Now;
        }
        [Required]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        [Required]
        [DisplayName("Attendence Date")]
        public DateTime AttendenceDate { get; set; }

        public ICollection<AttendenceListViewModel> AttendenceListViewModel { get; set; }
    }

    public class AttendenceListViewModel
    {
        public int AttendenceId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Mobile { get; set; }
        public DateTime JoininDate { get; set; }
    }
}
