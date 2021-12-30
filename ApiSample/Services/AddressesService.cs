﻿using ApiSample.Data.Models;
using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class AddressesService : Service<AddressesService>, IAddressesService
    {
        private readonly IAddressesRepository AddressesRepository;

        public AddressesService(INotifier notifier,
            ILogger<AddressesService> logger,
            IAddressesRepository addressesRepository)
            : base(notifier, logger)
        {
            AddressesRepository = addressesRepository;
        }

        public Task<Addresses> Create(Addresses address)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Addresses address)
        {
            throw new NotImplementedException();
        }

        public Task<Addresses?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Addresses> Edit(Addresses address)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Addresses>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
