using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using Apartment.App.Business.Abstract;
using Apartment.App.DataAccessEntityFramework.Repository.Abstract;
using Apartment.App.Domain.Entities;
using Apartment.App.Domain.Entities.IdentityEntities;

namespace Apartment.App.Business.Concrete
{
    public class HousingService:IHousingService
    {
        private readonly IRepository<Housing> repository;
        private readonly IUnitOfWork unitOfWork;
        public HousingService(IRepository<Housing> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public List<Housing> GetAllHousing()
        {
            return repository.Get().ToList();
        }

        public List<Housing> GetAllActiveHousings()
        {
            return repository.Get().Where(h=>h.IsDeleted == false).ToList();
        }

        public Housing GetHousingById(int housingId)
        {
            return repository.Get().Where(h => h.Id == housingId).First();
        }

        public Housing GetHousingByUser(User user)
        {
            return repository.Get().Where(h => h.User.Id == user.Id).First();
        }

        public void Add(Housing housing)
        {
            repository.Add(housing);
            unitOfWork.Commit();
        }

        public void Update(Housing housing)
        {
            repository.Update(housing);
            unitOfWork.Commit();
        }

        public void Delete(Housing housing)
        { 
           repository.Delete(housing);
           unitOfWork.Commit();
        }
    }
}
