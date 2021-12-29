using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class ClientsController : ControllerBase
    {
        /// <summary>
        /// Get all Clients
        /// </summary>
        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Client by Id.
        /// </summary>
        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Client.
        /// </summary>
        // POST api/<ClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Client.
        /// </summary>
        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Client.
        /// </summary>
        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
