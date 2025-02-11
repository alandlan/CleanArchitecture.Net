using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UseCases.UpdateUser
{
    public sealed record class UpdateUserRequest(Guid Id, string Name, string Email) : IRequest<UpdateUserResponse>;
}
