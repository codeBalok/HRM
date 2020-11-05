using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface ILeaveTypeRepository : IBaseRepository<LeaveTypeModel>
    {
        IEnumerable<SelectListItem> GetAllLeaveTypeForDropDown();
    }
}
