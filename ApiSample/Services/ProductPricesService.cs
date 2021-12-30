﻿using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class ProductPricesService : Service<ProductPricesService>, IProductPricesService
    {
        private readonly IProductPricesRepository ProductPricesRepository;

        public ProductPricesService(INotifier notifier,
            ILogger<ProductPricesService> logger,
            IProductPricesRepository productPricesRepository)
            : base(notifier, logger)
        {
            ProductPricesRepository = productPricesRepository;
        }

        public Task<ProductPrices> Create(ProductPrices productPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(ProductPrices productPrice)
        {
            throw new NotImplementedException();
        }

        public Task<ProductPrices?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductPrices> Edit(ProductPrices productPrice)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ProductPrices>> Get()
        {
            throw new NotImplementedException();
        }
    }
}