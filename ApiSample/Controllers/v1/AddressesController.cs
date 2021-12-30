using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class AddressesController : ControllerMain
    {
        private readonly IAddressesService AddressesService;

        public AddressesController(INotifier notifier,
            ILogger<AddressesController> logger,
            IAddressesService addressesService)
            : base(notifier, logger)
        {
            AddressesService = addressesService;
        }

        /// <summary>
        /// Get all Addresses
        /// </summary>
        // GET: api/<AddressesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get an Address by Id.
        /// </summary>
        // GET api/<AddressesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates an Address.
        /// </summary>
        // POST api/<AddressesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update an Address.
        /// </summary>
        // PUT api/<AddressesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete an Address.
        /// </summary>
        // DELETE api/<AddressesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
