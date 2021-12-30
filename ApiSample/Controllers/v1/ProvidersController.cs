using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class ProvidersController : ControllerMain
    {
        private readonly IProvidersService ProvidersService;

        public ProvidersController(INotifier notifier,
            ILogger<ProvidersController> logger,
            IProvidersService providersService)
            : base(notifier, logger)
        {
            ProvidersService = providersService;
        }

        /// <summary>
        /// Get all Providers
        /// </summary>
        // GET: api/<ProvidersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Provider by Id.
        /// </summary>
        // GET api/<ProvidersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Provider.
        /// </summary>
        // POST api/<ProvidersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Provider.
        /// </summary>
        // PUT api/<ProvidersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Provider.
        /// </summary>
        // DELETE api/<ProvidersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
