using GringottsBank.Core.Repositories.Base;
using GringottsBank.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GringottsBank.Infrastructure.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly GringottsContext _gringottsContext;
        public Repository(GringottsContext employeeContext)
        {
            _gringottsContext = employeeContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _gringottsContext.Set<T>().AddAsync(entity);
            await _gringottsContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _gringottsContext.Set<T>().Remove(entity);
            await _gringottsContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _gringottsContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _gringottsContext.Set<T>().FindAsync(id);
        }
        public async Task<int> UpdateAsync(T entity)
        {
            T foundEntity=_gringottsContext.Set<T>().Find(entity);
            _gringottsContext.Entry(foundEntity).CurrentValues.SetValues(entity);
            return await _gringottsContext.SaveChangesAsync();
        }
    }
}
