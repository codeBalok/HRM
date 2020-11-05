using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyHRM.Data.Repository
{
    public class EmployeeRepository : BaseRepository<EmployeeModel>, IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<EmployeeModel> AllByDepartmentId(int deptId)
        {
            if (deptId == 0)
                return All();
            return All().Where(x => x.DepertmentId == deptId);
        }

        public IEnumerable<SelectListItem> GetAllEmployeeExceptMappingForDropDown()
        {
            var employeesInMapping = context.LeaveEmployee.ToList().Where(x=>!x.IsDelete);
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var item in employeesInMapping)
            {
                var findEmployee = Find(item.EmployeeId);
                employees.Add(findEmployee);
            }
            var employeess = All().Except(employees);
            return employeess.ToList().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }

        public IEnumerable<SelectListItem> GetAllEmployeeForDropDown()
        {
            return All().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }
        public string NameById(int id)
        {
            var emp = Find(id);
            return emp.Name;
        }
    }
}
