using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiSample.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Model
    {
        private bool _disposed;
        protected readonly ApiSampleContext Context;

        protected Repository(ApiSampleContext context)
        {
            Context = context;
        }

        public virtual async Task<IList<T>> Get()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> Create(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> Edit(T entity)
        {
            Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T?> Details(Guid id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public virtual async Task<bool> Delete(Guid id)
        {
            var entity = await Context.Set<T>().FirstOrDefaultAsync(c => c.Id == id);

            if (entity == null)
                return false;
            
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();

            return true;            
        }

        public virtual async Task<bool> Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();

            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if (_disposed)
                return;

            if (dispose)
                Context?.Dispose();

            _disposed = true;
        }
    }
}
