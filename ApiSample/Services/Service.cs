using ApiSample.Services.Interfaces;
using ApiSample.Services.Notify;
using FluentValidation;
using FluentValidation.Results;

namespace ApiSample.Services
{
    public abstract class Service
    {
        private readonly INotifier _notifier;

        protected Service(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
                Notify(error.ErrorMessage);
        }

        protected void Notify(string message)
        {
            _notifier.Handle(new Notification(message));
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
