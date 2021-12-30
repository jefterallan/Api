using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class ProductsService : Service<ProductsService>, IProductsService
    {
        private readonly IProductsRepository ProductPricesRepository;

        public ProductsService(INotifier notifier,
            ILogger<ProductsService> logger,
            IProductsRepository productPricesRepository)
            : base(notifier, logger)
        {
            ProductPricesRepository = productPricesRepository;
        }

        public Task<Products> Create(Products product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Products product)
        {
            throw new NotImplementedException();
        }

        public Task<Products?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Products> Edit(Products product)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Products>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
