using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.Repository
{
    public class AttendenceRepository : BaseRepository<AttendenceModel>, IAttendenceRepository
    {
        public AttendenceRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<AttendenceModel> AttendenceListByEmployee(int empId)
        {
            throw new NotImplementedException();
        }
    }
}
