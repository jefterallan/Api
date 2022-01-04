using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
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
        [Route("Get")]
        [Authorize(Roles = "Admin")]
        //[AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<IList<AddressesDto>>> Get()
        {
            var result = await AddressesService.Get();

            return CustomResponse(result);
        }

        /// <summary>
        /// Get an Address by Id.
        /// </summary>
        // GET api/<AddressesController>/5
        [HttpGet]
        [Route("Details")]
        //[Authorize(Roles = "admin")]
        //[AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<AddressesDto>> Details(Guid id)
        {
            var result = await AddressesService.Details(id);

            return CustomResponse(result);
        }

        /// <summary>
        /// Creates an Address.
        /// </summary>
        // POST api/<AddressesController>
        [HttpPost]
        [Route("Create")]
        //[Authorize(Roles = "admin")]
        //[AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<AddressesDto>> Create(AddressesDto addresses)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var result = await AddressesService.Create(addresses);

            return CustomResponse(result);
        }

        /// <summary>
        /// Update an Address.
        /// </summary>
        // PUT api/<AddressesController>/5
        [HttpPut]
        [Route("Edit")]
        //[Authorize(Roles = "admin")]
        //[AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<AddressesDto>> Edit(AddressesDto addresses)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var result = await AddressesService.Edit(addresses);

            return CustomResponse(result);
        }

        /// <summary>
        /// Delete an Address.
        /// </summary>
        // DELETE api/<AddressesController>/5
        [HttpDelete]
        [Route("Delete")]
        //[Authorize(Roles = "admin")]
        //[AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var result = await AddressesService.Delete(id);

            return CustomResponse(result);
        }
    }
}
