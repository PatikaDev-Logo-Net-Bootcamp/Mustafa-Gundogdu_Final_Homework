using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Web.Models.UserViewModels;

namespace Apartment.App.Web.Models.HousingViewModels
{
    public class HousingViewModel
    {
        public UserViewModel User { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsHomeowner { get; set; }
        public int BlokNumber { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string ApartmentSizeInfo { get; set; }
        
    }
}
