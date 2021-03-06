﻿using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface IAttendenceRepository : IBaseRepository<AttendenceModel>
    {
        IEnumerable<AttendenceModel> AttendenceListByEmployee(int empId);
    }
}
