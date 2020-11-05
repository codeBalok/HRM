using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.Repository
{
    public class LeaveApplicationRepository : BaseRepository<LeaveApplicationModel>, ILeaveApplicationRepository
    {
        public LeaveApplicationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
