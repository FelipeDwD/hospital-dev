using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.WebApi.Infra.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntityModel, new()
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public virtual async Task<List<T>> GetAsync() =>
            await _dbSet.ToListAsync();

        public virtual async Task<T> GetByIdAsync(Guid id) =>
            await _dbSet.FindAsync(id);        

        public virtual async Task<bool> RemoveAsync(Guid id)
        {
            var t = new T() { Id = id };
            _dbSet.Remove(t);
            await SaveChangesAsync();
            return true;
        }

        public virtual async Task<T> SaveAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await SaveChangesAsync();
            return entity;
        }

        protected async Task<int> SaveChangesAsync() =>
            await _dbContext.SaveChangesAsync();

        protected void Dispose() =>
            _dbContext?.Dispose();
    }
}
