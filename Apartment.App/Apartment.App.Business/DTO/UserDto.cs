using System;
using System.Collections.Generic;
using System.Text;

namespace Apartment.App.Business.DTO
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TrIdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public bool HasCar { get; set; }
        public string CarPlateNumber { get; set; }
    }
}
