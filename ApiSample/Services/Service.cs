using ApiSample.Data.Models;
using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using FluentValidation;
using FluentValidation.Results;

namespace ApiSample.Services
{
    public abstract class Service<T> where T : class
    {
        protected ILogger<T> Logger { get; set; }
        private readonly INotifier Notifier;

        protected Service(INotifier notifier, ILogger<T> logger)
        {
            Notifier = notifier;
            Logger = logger;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
                Notify(error.ErrorMessage);
        }

        protected void Notify(string message)
        {
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
