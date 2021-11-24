using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.WebApi.Service.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntityModel
    {
        protected readonly IRepository<T> _repository;
        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<List<T>> GetAsync() =>
            await _repository.GetAsync();

        public virtual async Task<T> GetByIdAsync(Guid id) =>
            await _repository.GetByIdAsync(id);

        public virtual async Task<bool> RemoveAsync(Guid id) =>
            await _repository.RemoveAsync(id);

        public virtual async Task<T> SaveAsync(T entity) =>
            await _repository.SaveAsync(entity);

        public virtual async Task<T> UpdateAsync(T entity) =>
            await _repository.UpdateAsync(entity);        
    }
}
