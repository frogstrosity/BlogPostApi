using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlogPostApi.Data.Static
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext context;
        public EfCoreRepository(TContext context)
        {
            this.context = context;
        }

        public Task<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public Task<TEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
