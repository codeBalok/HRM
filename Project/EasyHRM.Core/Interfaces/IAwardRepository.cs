using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface IAwardRepository : IBaseRepository<AwardModel>
    {
        IEnumerable<AwardModel> AwardListByEmployeeId(int empId);
    }
}
