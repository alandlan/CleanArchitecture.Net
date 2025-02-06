using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UseCases.GetAllUser
{
    public sealed class GetAllUserMapper : Profile
    {
        public GetAllUserMapper()
        {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}
