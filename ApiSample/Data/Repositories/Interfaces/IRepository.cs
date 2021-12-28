using ApiSample.Data.Models;

namespace ApiSample.Data.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Model
    {
    }
}
