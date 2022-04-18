using System.Collections.Generic;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities.IdentityEntities;

namespace Apartment.App.Web.Models.HousingViewModels
{
    public class HousingAddViewModel
    {
        public HousingDto Housing { get; set; } = new HousingDto();
        public List<UserDto> Users { get; set; } = new List<UserDto>();
        public string HousingHirerTcIdentityNumber { get; set; }
    }
}
