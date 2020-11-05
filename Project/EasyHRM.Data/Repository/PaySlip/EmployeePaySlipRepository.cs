using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Core.Interfaces.PaySlip;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.Repository.PaySlip
{
    public class EmployeePaySlipRepository : BaseRepository<EmployeePaySlipModel>, IEmployeePaySlipRepository
    {
        public EmployeePaySlipRepository(AppDbContext context) : base(context)
        {
        }
    }
}
