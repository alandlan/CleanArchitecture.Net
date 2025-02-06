using MediatR;

namespace CleanArch.Application.UseCases.GetAllUser
{
    //public sealed record GetAllUserRequest() : IRequest<GetAllUserResponse>;
    public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>, IBaseRequest, IEquatable<GetAllUserRequest>
    {
    }
}
