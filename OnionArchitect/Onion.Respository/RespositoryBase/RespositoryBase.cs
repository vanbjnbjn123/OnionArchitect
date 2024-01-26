using System;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Onion.Domain.Models;
using Onion.Respository.Interfaces;

namespace Onion.Respository.RespositoryBase
{
	public class RespositoryBase<T> : IRespositoryBase<T> where T: EntityBase
	{
        private readonly OnionDBContext _dbContext;
        public DbSet<T> entities;
        public RespositoryBase(OnionDBContext dbContext)
		{
            _dbContext = dbContext;
            entities = _dbContext.Set<T>();
		}

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(T));
            }
            T entityResult = entities.Find(entities);
            if(entityResult == null)
            {
                throw new Exception("could be not found anything");
            }
            entityResult.IsActive = false;
            _dbContext.Update(entityResult);
        }

        public T Get(int Id)
        {
            return entities.Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
        }

    }
}

