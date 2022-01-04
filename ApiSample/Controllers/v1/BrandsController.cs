using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BrandsController : ControllerMain
    {
        private readonly IBrandsService BrandsService;

        public BrandsController(INotifier notifier,
            ILogger<BrandsController> logger,
            IBrandsService brandsService)
            : base(notifier, logger)
        {
            BrandsService = brandsService;
        }

        /// <summary>
        /// Get all Brands
        /// </summary>
        // GET: api/<BrandsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Brand by Id.
        /// </summary>
        // GET api/<BrandsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Brand.
        /// </summary>
        // POST api/<BrandsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Brand.
        /// </summary>
        // PUT api/<BrandsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Brand.
        /// </summary>
        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
