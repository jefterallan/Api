using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface IService<T> where T : ModelDto
    {
        abstract Task<IList<T>> Get();
        abstract Task<T> Create(T model);
        abstract Task<T> Edit(T model);
        abstract Task<T?> Details(Guid id);
        abstract Task<bool> Delete(Guid id);
    }
}
