using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class OrdersController : ControllerMain
    {
        private readonly IOrdersService OrdersService;

        public OrdersController(INotifier notifier,
            ILogger<OrdersController> logger,
            IOrdersService ordersService)
            : base(notifier, logger)
        {
            OrdersService = ordersService;
        }

        /// <summary>
        /// Get all Orders
        /// </summary>
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get an Order by Id.
        /// </summary>
        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates an Order.
        /// </summary>
        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update an Order.
        /// </summary>
        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete an Order.
        /// </summary>
        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
