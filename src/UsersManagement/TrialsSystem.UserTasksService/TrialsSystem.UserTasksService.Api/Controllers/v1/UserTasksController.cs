using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UserTasksService.Api.Application.UserTask.Commands;
using TrialsSystem.UserTasksService.Api.Application.UserTask.Queries;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserTaskDto;

namespace TrialsSystem.UserTasksService.Api.Controllers.v1
{
    [Route("api/v1{userId}/[controller]")]
    [ApiController]
    public class UserTasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly IValidator<CreateUserTaskRequest> _createUserTaskValidator;
        private readonly IValidator<UpdateUserTaskRequest> _updateUserTaskValidator;

        public UserTasksController(IMediator mediator,
            IValidator<CreateUserTaskRequest> createUserTaskValidator,
            IValidator<UpdateUserTaskRequest> updateUserTaskValidator)
        {
            _mediator = mediator;
            _createUserTaskValidator = createUserTaskValidator;
            _updateUserTaskValidator = updateUserTaskValidator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetUserTaskResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null)
        {
            var response = await _mediator.Send(new UserTasksQuery(take, skip));
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new UserTaskQuery(id));
            return Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(typeof(CreateUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(
            [FromRoute] string userId,
            CreateUserTaskRequest request)
        {
            var validationResult = _createUserTaskValidator.Validate(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToString());
            }

            var response = await _mediator.Send(new CreateUserTaskCommand(request.Name,
                request.Status,
                request.AdditionalProperties));
            return Ok(response);

        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(
            [FromRoute] string userId,
            string id,
            UpdateUserTaskRequest request)
        {
            var validationResult = _updateUserTaskValidator.Validate(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.ToString());
            }

            var response = await _mediator.Send(new UpdateUserTaskCommand(id,
                request.Name,
                request.Status,
                request.AdditionalProperties));
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] string userId,
            string Id)
        {
            var response = await _mediator.Send(new DeleteUserTaskCommand(Id));
            return Ok();
        }
    }
}
