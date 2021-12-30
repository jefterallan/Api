using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class ProductPricesController : ControllerMain
    {
        private readonly IProductPricesService ProductPricesService;

        public ProductPricesController(INotifier notifier,
            ILogger<ProductPricesController> logger,
            IProductPricesService productPricesService)
            : base(notifier, logger)
        {
            ProductPricesService = productPricesService;
        }

        /// <summary>
        /// Get all Product Prices
        /// </summary>
        // GET: api/<ProductPricesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Product Price by Id.
        /// </summary>
        // GET api/<ProductPricesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Product Price.
        /// </summary>
        // POST api/<ProductPricesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Product Price.
        /// </summary>
        // PUT api/<ProductPricesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Product Price.
        /// </summary>
        // DELETE api/<ProductPricesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
