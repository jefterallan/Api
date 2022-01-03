using ApiSample.Data.Models;
using ApiSample.Services.Dto;
using AutoMapper;

namespace ApiSample.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Model, ModelDto>();
            CreateMap<Credential, CredentialDto>();
            //CreateMap<Addresses, AddressesDto>();
            //CreateMap<Brands, BrandsDto>();
            //CreateMap<Clients, ClientsDto>();
            //CreateMap<Groups, GroupsDto>();
            //CreateMap<Invoices, InvoicesDto>();
            //CreateMap<Orders, OrdersDto>();
            //CreateMap<PaymentClients, PaymentClientsDto>();
            //CreateMap<PaymentProviders, PaymentProvidersDto>();
            //CreateMap<Prices, PricesDto>();
            //CreateMap<ProductPrices, ProductPricesDto>();
            //CreateMap<Products, ProductsDto>();
            //CreateMap<Providers, ProvidersDto>();

            //CreateMap<Groups, GroupsDto>()
            //    .ForMember(u => u.Users, m => m.MapFrom(a => a.Users));

            CreateMap<Users, UsersDto>()
                .ForMember(u => u.Group, m => m.MapFrom(a => a.Group));

            //CreateMap<GroupsDto, Groups>();
            //CreateMap<UsersDto, Users>();
            //CreateMap<CredentialDto, Credential>();
            //CreateMap<ModelDto, Model>();

        }
    }
}
