using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities;
using AutoMapper;

namespace Apartment.App.Web.Mapping.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //ilk yer source ikinci yer target
            CreateMap<Floor, FloorDto>();
        }
    }
}
