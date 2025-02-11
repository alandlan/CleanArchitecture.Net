using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UseCases.DeleteUser
{
    public sealed record DeleteUserResponse
    {
        public DeleteUserResponse(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; init; }
    }
}
