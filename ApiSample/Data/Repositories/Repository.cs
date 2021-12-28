using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;

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
