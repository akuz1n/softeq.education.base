using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Api.Application.Commands;
using TrialsSystem.UsersService.Api.Application.Queries;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    /// <summary>
    /// City management controller
    /// </summary>
    [Route("api/v1/{userId}/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all cities
        /// </summary>
        /// <param name="userId">authorized user Id</param>
        /// <param name="skip">skip items (pagination parameters)</param>
        /// <param name="take">take items (pagination parameters)</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetCityResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null)
        {
            var response = await _mediator.Send(new CitiesQuery(take, skip));
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(
            [FromRoute] string userId,
            string name)
        {
            var response = await _mediator.Send(new CreateCityCommand(name));
            return Ok();

        }

        [HttpPut("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(
            [FromRoute] string userId,
            string name,
            string newName)
        {
            var response = await _mediator.Send(new UpdateCityCommand(name, newName));
            return Ok();
        }

        [HttpDelete("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] string userId,
            string name)
        {
            var response = await _mediator.Send(new DeleteCityCommand(name));
            return Ok();
        }
    }
}
