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

        public virtual ICollection<T> Get()
        {
            return Search.ToList();
        }

        public virtual async IAsyncEnumerable<T> Create(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();

            yield return entity;
        }

        public virtual async IAsyncEnumerable<T> Edit(T entity)
        {
            Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();

            yield return entity;
        }

        public virtual async IAsyncEnumerable<T?> Details(Guid id)
        {
            yield return await Search.FirstOrDefaultAsync(c => c.Id == id);
        }

        public virtual async IAsyncEnumerable<bool> Delete(Guid id)
        {
            var entity = await Search.FirstOrDefaultAsync(c => c.Id == id);

            if (entity != null)
            {
                Context.Set<T>().Remove(entity);
                await Context.SaveChangesAsync();

                yield return true;
            }

            yield return false;
        }

        public virtual async IAsyncEnumerable<bool> Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();

            yield return true;
        }

        public virtual IQueryable<T> Search
        {
            get { return from c in Context.Set<T>() select c; }
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
