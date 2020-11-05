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
    public class LeaveGroupRepository : BaseRepository<LeaveGroupModel>, ILeaveGroupRepository
    {
        public LeaveGroupRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<SelectListItem> GetAllLeaveGroupForDropDown()
        {
            return All().Select(x => new SelectListItem
            {
                Text = x.LeaveGroupName,
                Value = x.Id.ToString()
            });
        }
    }
}
