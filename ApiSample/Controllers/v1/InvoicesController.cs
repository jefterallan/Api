using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class InvoicesController : ControllerMain
    {
        private readonly IInvoicesService InvoicesService;

        public InvoicesController(INotifier notifier,
            ILogger<InvoicesController> logger,
            IInvoicesService invoicesService)
            : base(notifier, logger)
        {
            InvoicesService = invoicesService;
        }

        /// <summary>
        /// Get all Invoices
        /// </summary>
        // GET: api/<InvoicesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Invoice by Id.
        /// </summary>
        // GET api/<InvoicesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Invoice.
        /// </summary>
        // POST api/<InvoicesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Invoice.
        /// </summary>
        // PUT api/<InvoicesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Invoice.
        /// </summary>
        // DELETE api/<InvoicesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
