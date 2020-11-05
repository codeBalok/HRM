using EasyHRM.Core.DataModel;
using EasyHRM.Core.Interfaces.Base;
using EasyHRM.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Core.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        //bool ValidateUser(LoginViewModel user);
    }
}
