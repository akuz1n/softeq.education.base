using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Api.Application.City.Commands;
using TrialsSystem.UsersService.Api.Application.City.Queries;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

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
        private readonly IValidator<CreateCityRequest> _createCityValidator;
        private readonly IValidator<UpdateCityRequest> _updateCityValidator;

        public CitiesController(IMediator mediator,
            IValidator<CreateCityRequest> createCityValidator,
            IValidator<UpdateCityRequest> updateCityValidator)
        {
            _mediator = mediator;
            _createCityValidator = createCityValidator;
            _updateCityValidator = updateCityValidator;
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

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetCityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new CityQuery(id));
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CreateCityResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(
            [FromRoute] string userId,
            CreateCityRequest request)
        {
            var validationResult = _createCityValidator.Validate(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToString());
            }

            var response = await _mediator.Send(new CreateCityCommand(request.Name));
            return Ok(response);

        }

        [HttpPut("id")]
        [ProducesResponseType(typeof(UpdateCityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(
            [FromRoute] string userId,
            string id,
            UpdateCityRequest request)
        {
            var validationResult = _updateCityValidator.Validate(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToString());
            }

            var response = await _mediator.Send(new UpdateCityCommand(id, request.Name));
            return Ok(response);
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] string userId,
            string id)
        {
            var response = await _mediator.Send(new DeleteCityCommand(id));
            return Ok();
        }
    }
}
