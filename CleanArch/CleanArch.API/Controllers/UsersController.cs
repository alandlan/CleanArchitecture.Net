using CleanArch.Application.UseCases.CreateUser;
using CleanArch.Application.UseCases.DeleteUser;
using CleanArch.Application.UseCases.GetAllUser;
using CleanArch.Application.UseCases.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request, CancellationToken cancellationToken)
        {
            //var validator = new CreateUserValidator();
            //var validationResult = await validator.ValidateAsync(request, cancellationToken);

            //if (!validationResult.IsValid)
            //{
            //    return BadRequest(validationResult.Errors);
            //}

            var result = await _mediator.Send(request,cancellationToken);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            //var validator = new UpdateUserValidator();
            //var validationResult = await validator.ValidateAsync(request, cancellationToken);
            //if (!validationResult.IsValid)
            //{
            //    return BadRequest(validationResult.Errors);
            //}
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            //var validator = new DeleteUserValidator();
            //var validationResult = await validator.ValidateAsync(id, cancellationToken);
            //if (!validationResult.IsValid)
            //{
            //    return BadRequest(validationResult.Errors);
            //}
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}
