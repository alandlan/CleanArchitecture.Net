using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UseCases.UpdateUser
{
    public sealed class UpdateUserMapper : Profile
    {
        public UpdateUserMapper()
        {
            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserResponse>();
        }
    }
}
