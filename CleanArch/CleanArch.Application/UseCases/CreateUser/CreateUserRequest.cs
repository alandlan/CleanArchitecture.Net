using MediatR;

namespace CleanArch.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Email,string Name) : IRequest<CreateUserResponse>;
    
}
