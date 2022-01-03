using ApiSample.Data.Models;
using ApiSample.Services.Dto;
using AutoMapper;

namespace ApiSample.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Addresses, AddressesDto>();
            CreateMap<Brands, BrandsDto>();
            CreateMap<Clients, ClientsDto>();
            CreateMap<Groups, ClientsDto>();
            CreateMap<Invoices, InvoicesDto>();
            CreateMap<Orders, OrdersDto>();
            CreateMap<PaymentClients, PaymentClientsDto>();
            CreateMap<PaymentProviders, PaymentProvidersDto>();
            CreateMap<Prices, PricesDto>();
            CreateMap<ProductPrices, ProductPricesDto>();
            CreateMap<Products, ProductsDto>();
            CreateMap<Providers, ProvidersDto>();
            CreateMap<Users, UsersDto>();
        }
    }
}
