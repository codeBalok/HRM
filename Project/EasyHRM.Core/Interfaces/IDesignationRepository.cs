using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface IDesignationRepository : IBaseRepository<DesignationModel>
    {
        IEnumerable<SelectListItem> GetAllDesignationForDropDown();
        IEnumerable<DesignationModel> AllDesignationByDepartmentId(int dptId);
        bool AlreadyExist(string deptName, int id);
    }
}
