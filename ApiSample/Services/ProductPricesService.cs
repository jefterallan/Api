﻿using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class ProductPricesService : Service, IProductPricesService
    {
        private readonly IProductPricesRepository ProductPricesRepository;

        public ProductPricesService(ILogger<ProductPricesService> logger,
            IMapper mapper,
            INotifier notifier,
            IProductPricesRepository productPricesRepository)
            : base(logger, mapper, notifier)
        {
            ProductPricesRepository = productPricesRepository;
        }

        public async Task<ProductPricesDto> Create(ProductPricesDto productPrice)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductPricesDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductPricesDto> Edit(ProductPricesDto productPrice)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ProductPricesDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
