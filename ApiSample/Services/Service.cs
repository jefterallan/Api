using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;

namespace ApiSample.Services
{
    public abstract class Service
    {
        protected ILogger Logger { get; set; }
        protected IMapper Mapper { get; set; }
        private readonly INotifier Notifier;

        protected Service(ILogger logger,
            IMapper mapper,
            INotifier notifier)
        {
            Logger = logger;
            Mapper = mapper;
            Notifier = notifier;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
                Notify(error.ErrorMessage);
        }

        protected void Notify(string message)
        {
            Logger.LogWarning(message);
            Notifier.Handle(new NotificationsDto(message));
        }

        protected bool ValidateModel<TV, TE>(TV validation, TE entity) where TV : AbstractValidator<TE> where TE : class
        {
            var validator = validation.Validate(entity);

            if (validator.IsValid)
                return true;

            Notify(validator);

            return false;
        }
    }
}
