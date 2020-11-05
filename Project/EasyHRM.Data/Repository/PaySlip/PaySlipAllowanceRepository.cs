using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces.PaySlip;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.Repository.PaySlip
{
    public class PaySlipAllowanceRepository : BaseRepository<PaySlipAllowanceModel>, IPaySlipAllowanceRepository
    {
        public PaySlipAllowanceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
