using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces;
using EasyHRM.Data.HRMdbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.Repository.Base
{
    public class CompanyRepository : BaseRepository<CompanyModel>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {

        }
    }
}
