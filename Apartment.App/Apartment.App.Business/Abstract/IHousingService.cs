using System;
using System.Collections.Generic;
using System.Text;
using Apartment.App.Domain.Entities;
using Apartment.App.Domain.Entities.IdentityEntities;

namespace Apartment.App.Business.Abstract
{
    public interface IHousingService
    {
         List<Housing> GetAllHousing();
         List<Housing> GetAllActiveHousings();
         Housing GetHousingById(int housingId);
         List<Housing> GetHousingsByUserId(string userId);
         
         void Add(Housing housing);
         void Update(Housing housing);
         void Delete(Housing housing);

    }
}
