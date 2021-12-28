using ApiSample.Services.Interfaces;
using ApiSample.Services.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    public abstract class ControllerMain : ControllerBase
    {
        private readonly INotifier _notifier;
        private readonly ILogger<ControllerMain> _logger;

        protected ControllerMain(INotifier notifier, ILogger<ControllerMain> logger)
        {
            _notifier = notifier;
            _logger = logger;
        }

        protected bool ValidOperation()
        {
            return !_notifier.HasNotification();
        }

        protected void NotifyErrorToInvalidModel(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(x => x.Errors);

            foreach (var error in errors)
            {
                var errorMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                NotifyError(errorMsg);
            }
        }

        protected void NotifyError(string errorMsg)
        {
            _notifier.Handle(new Notification(errorMsg));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
                NotifyErrorToInvalidModel(modelState);

            return CustomResponse();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        protected ActionResult CustomResponse(object? result = null)
        {
            if (ValidOperation())
            {
                return Ok(new Response(true, result));
            }

            var errorsFound = _notifier.GetNotifications().Select(x => x.Message);

            foreach (var error in errorsFound)
                _logger.LogWarning(error);

            return BadRequest(new Response(false, errorsFound));
        }
    }
}
