using SEDC.PizzaApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IUserService
    {
        List<UserDDViewModel> GetUsersForDropdown();
    }
}
