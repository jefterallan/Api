using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;

namespace ApiSample.Services
{
    public class ProductsService : Service<ProductsService>, IProductsService
    {
        private readonly IProductsRepository ProductPricesRepository;

        public ProductsService(INotifier notifier,
            ILogger<ProductsService> logger,
            IMapper mapper,
            IProductsRepository productPricesRepository)
            : base(notifier, logger, mapper)
        {
            ProductPricesRepository = productPricesRepository;
        }

        public async Task<ProductsDto> Create(ProductsDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductsDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductsDto> Edit(ProductsDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ProductsDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
