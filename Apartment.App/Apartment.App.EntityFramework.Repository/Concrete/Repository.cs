﻿using System;
using System.Linq;
using Apartment.App.DataAccessEntityFramework.Repository.Abstract;
using Apartment.App.Domain.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace Apartment.App.DataAccessEntityFramework.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly IUnitOfWork unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add(T entity)
        {
            entity.IsDeleted = false;
            entity.CreatedAt=DateTime.Now;
            unitOfWork.Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            T exist = unitOfWork.Context.Set<T>().Find(entity.Id);
            if (exist != null)
            {
                exist.IsDeleted = true;
                unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            }
        }

        public IQueryable<T> Get()
        {
            return unitOfWork.Context.Set<T>().Where(x => !x.IsDeleted).AsQueryable();
        }

        public void Update(T entity)
        {
            T exist = unitOfWork.Context.Set<T>().Find(entity.Id);
            if (exist != null)
            {
                exist.LastUpdatedAt = DateTime.Now;
                unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            }
            
        }
    }
}