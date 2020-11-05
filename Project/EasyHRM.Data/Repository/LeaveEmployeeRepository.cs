using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;

namespace EasyHRM.Data.Repository
{
    public class LeaveEmployeeRepository : BaseRepository<LeaveEmployeeModel>, ILeaveEmployeeRepository
    {
        public LeaveEmployeeRepository(AppDbContext context) : base(context)
        {
        }

        
    }
}
