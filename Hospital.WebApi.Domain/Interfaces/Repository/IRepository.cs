using Hospital.WebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.WebApi.Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseEntityModel
    {
        Task<T> SaveAsync(T entity);
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task<bool> RemoveAsync(Guid id);
    }
}
