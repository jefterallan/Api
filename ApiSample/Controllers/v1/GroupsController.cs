using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class GroupsController : ControllerMain
    {
        private readonly IGroupsService GroupsService;

        public GroupsController(INotifier notifier,
            ILogger<GroupsController> logger,
            IGroupsService groupsService)
            : base(notifier, logger)
        {
            GroupsService = groupsService;
        }

        /// <summary>
        /// Get all Groups
        /// </summary>
        // GET: api/<GroupsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a Group by Id.
        /// </summary>
        // GET api/<GroupsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Creates a Group.
        /// </summary>
        // POST api/<GroupsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a Group.
        /// </summary>
        // PUT api/<GroupsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete a Group.
        /// </summary>
        // DELETE api/<GroupsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
