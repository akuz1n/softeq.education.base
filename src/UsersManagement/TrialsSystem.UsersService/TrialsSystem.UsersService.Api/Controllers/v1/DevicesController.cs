using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;
using MediatR;
using TrialsSystem.UsersService.Api.Application.Commands;
using TrialsSystem.UsersService.Api.Application.Queries;
using TrialsSystem.UsersService.Api.Filters;
using FluentValidation;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    /// <summary>
    /// Device management controller
    /// </summary>
    [Route("api/v1/{userId}/[controller]")]
    [ServiceFilter(typeof(UserExceptionFilter))]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DevicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all devices by setting parameters and filters
        /// </summary>
        /// <param name="userId">authorized user Id</param>
        /// <param name="skip">skip items (pagination parameters)</param>
        /// <param name="take">take items (pagination parameters)</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetDeviceResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null)
        {
            var response = await _mediator.Send(new DevicesQuery(take, skip));
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetDeviceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new DeviceQuery(id));
            return Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(typeof(CreateDeviceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(
            [FromRoute] string userId,
            CreateDeviceRequest request)
        {
            var response = await _mediator.Send(new CreateDeviceCommand(request.SerialNumber,
                                                                             request.Model,
                                                                             request.TypeId,
                                                                             request.FirmwareVersion));
            return Ok(response);

        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateDeviceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(
            [FromRoute] string userId,
            string id,
            UpdateDeviceRequest request)
        {
            var response = await _mediator.Send(new UpdateDeviceCommand(id,
                                                                        request.SerialNumber,
                                                                        request.Model,
                                                                        request.TypeId,
                                                                        request.FirmwareVersion));
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] string userId,
            string Id)
        {
            var response = await _mediator.Send(new DeleteDeviceCommand(Id));
            return Ok();
        }
    }
}
