using System.Collections.Generic;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities.IdentityEntities;

namespace Apartment.App.Web.Models.HousingViewModels
{
    public class HousingAddViewModel
    {
        public int Id { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsHomeowner { get; set; }
        public int FloorNumber { get; set; }
        public int BlockNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string ApartmentSizeInfo { get; set; }
        public string HousingHirerTcIdentityNumber { get; set; }
    }

}
