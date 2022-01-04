using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PaymentClientsController : ControllerMain
    {
        private readonly IPaymentClientsService PaymentClientsService;

        public PaymentClientsController(INotifier notifier,
            ILogger<PaymentClientsController> logger,
            IPaymentClientsService paymentClientsService)
            : base(notifier, logger)
        {
            PaymentClientsService = paymentClientsService;
        }

        /// <summary>
        /// Get all Payment Clients
        /// </summary>
        // GET: api/<PaymentClientsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Payment Client by Id.
        /// </summary>
        // GET api/<PaymentClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Payment Client.
        /// </summary>
        // POST api/<PaymentClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a PaymentClient.
        /// </summary>
        // PUT api/<PaymentClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Payment Client.
        /// </summary>
        // DELETE api/<PaymentClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
