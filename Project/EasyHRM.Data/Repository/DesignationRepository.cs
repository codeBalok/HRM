using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyHRM.Data.Repository.Base
{
    public class DesignationRepository : BaseRepository<DesignationModel>, IDesignationRepository
    {
        public DesignationRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<DesignationModel> AllDesignationByDepartmentId(int dptId)
        {
            return All().Where(x => x.DepertmentId == dptId).ToList();
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

        public IEnumerable<SelectListItem> GetAllDesignationForDropDown()
        {
            return All().ToList().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }

       
    }
}
