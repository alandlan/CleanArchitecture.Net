using MediatR;

namespace CleanArch.Application.UseCases.DeleteUser
{
    public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;
}