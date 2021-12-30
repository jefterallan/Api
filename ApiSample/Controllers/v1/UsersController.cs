using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class UsersController : ControllerMain
    {
        private readonly IUsersService UsersService;

        public UsersController(INotifier notifier,
            ILogger<UsersController> logger,
            IUsersService usersService)
            : base(notifier, logger)
        {
            UsersService = usersService;
        }

        /// <summary>
        /// Get all Users
        /// </summary>
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a User by Id.
        /// </summary>
        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a User.
        /// </summary>
        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a User.
        /// </summary>
        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a User.
        /// </summary>
        // DELETE api/<BUsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
