using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PaymentProvidersController : ControllerMain
    {
        private readonly IPaymentProvidersService PaymentProvidersService;

        public PaymentProvidersController(INotifier notifier,
            ILogger<PaymentProvidersController> logger,
            IPaymentProvidersService paymentProvidersService)
            : base(notifier, logger)
        {
            PaymentProvidersService = paymentProvidersService;
        }

        /// <summary>
        /// Get all Payment Providers
        /// </summary>
        // GET: api/<PaymentProvidersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Payment Provider by Id.
        /// </summary>
        // GET api/<PaymentProvidersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Payment Provider.
        /// </summary>
        // POST api/<PaymentProvidersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Payment Provider.
        /// </summary>
        // PUT api/<PaymentProvidersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Payment Provider.
        /// </summary>
        // DELETE api/<PaymentProvidersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
