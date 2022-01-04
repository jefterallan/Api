using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PricesController : ControllerMain
    {
        private readonly IPricesService PricesService;

        public PricesController(INotifier notifier,
            ILogger<PricesController> logger,
            IPricesService pricesService)
            : base(notifier, logger)
        {
            PricesService = pricesService;
        }

        /// <summary>
        /// Get all Prices
        /// </summary>
        // GET: api/<PricesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Price by Id.
        /// </summary>
        // GET api/<PricesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Price.
        /// </summary>
        // POST api/<PricesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Price.
        /// </summary>
        // PUT api/<PricesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Price.
        /// </summary>
        // DELETE api/<PricesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
