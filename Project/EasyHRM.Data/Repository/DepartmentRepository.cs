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
    public class DepartmentRepository : BaseRepository<DepartmentModel>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }

        

        public bool AlreadyExist(string deptName, int id)
        {
            if (id > 0)
            {
                var brand = All().FirstOrDefault(x => x.Name == deptName && id != x.Id);
                return brand != null;
            }
            else
            {
                var brand = All().FirstOrDefault(x => x.Name == deptName);
                return brand != null;
            }
        }

        public IEnumerable<SelectListItem> GetAllDepertmentForDropDown()
        {
            return All().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }

       
    }
}
