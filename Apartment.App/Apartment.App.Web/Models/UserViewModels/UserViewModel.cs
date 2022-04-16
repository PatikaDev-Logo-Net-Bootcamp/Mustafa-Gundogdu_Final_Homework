using System.Collections.Generic;
using Apartment.App.Business.DTO;

namespace Apartment.App.Web.Models.UserViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Users = new List<UserDto>();
        }
        public List<UserDto> Users { get ; set; }

    }
}
