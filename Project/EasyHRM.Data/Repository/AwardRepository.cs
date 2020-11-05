using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.Repository
{
    public class AwardRepository : BaseRepository<AwardModel>, IAwardRepository
    {
        public AwardRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<AwardModel> AwardListByEmployeeId(int empId)
        {
            throw new NotImplementedException();
        }
    }
}
