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
    public class AllowanceTypeRepository : BaseRepository<AllowanceTypeModel>, IAllowanceTypeRepository
    {
        public AllowanceTypeRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<SelectListItem> GetAllForDropDown()
        {
            return All().Select(x => new SelectListItem
            {
                Text = x.AllowanceTypeName,
                Value = x.AllowanceTypeName.ToString()
            });
        }
    }
}
