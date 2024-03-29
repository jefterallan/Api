﻿using ApiSample.Data.Repositories.Interfaces;
using ApiSample.Helpers;
using ApiSample.Services.Dto;
using ApiSample.Services.Dto.Validations;
using ApiSample.Services.Interfaces;
using AutoMapper;
using System.Security.Cryptography;
using System.Text;

namespace ApiSample.Services
{
    public class UsersService : Service, IUsersService
    {
        private readonly IUsersRepository UsersRepository;

        public UsersService(ILogger<UsersService> logger,
            IMapper mapper,
            INotifier notifier,
            IUsersRepository usersRepository)
            : base(logger, mapper, notifier)
        {
            UsersRepository = usersRepository;
        }

        public async Task<UsersDto?> FindApiCredentials(CredentialDto credential)
        {
            if (credential == null)
            {
                Notify("Credentials cannot be null");
                return null;
            }

            if (!ValidateModel(new CredentialValidation(), credential))
                return null;

            credential.Password = SharedExtentions.EncryptSHA512(credential.Password);

            var result = await UsersRepository.FindApiCredentials(credential);

            return Mapper.Map<UsersDto>(result);
        }

        public async Task<IList<UsersDto>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<UsersDto> Create(UsersDto model)
        {
            throw new NotImplementedException();
        }

        public async Task<UsersDto> Edit(UsersDto model)
        {
            throw new NotImplementedException();
        }

        public async Task<UsersDto?> Details(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }        
    }
}
