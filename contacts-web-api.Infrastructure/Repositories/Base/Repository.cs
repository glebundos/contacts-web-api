using contacts_web_api.Core.Repositories.Base;
using contacts_web_api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ContactsContext _contactContext;

        public Repository(ContactsContext contactContext)
        {
            _contactContext = contactContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _contactContext.Set<T>().AddAsync(entity); 
            await _contactContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _contactContext.Set<T>().Remove(entity);
            await _contactContext.SaveChangesAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _contactContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _contactContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _contactContext.SetModified(entity);
            await _contactContext.SaveChangesAsync();
            return entity;
        }
    }
}
