using AutoMapper;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.UseCases.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateUserHandler(IUserRepository userRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            if (user == null) {
                throw new Exception("Entity could not be mapped.");
            }
            var oldUser = await _userRepository.GetByIdAsync(user.Id,cancellationToken);
            if (oldUser == null)
            {
                throw new Exception("Entity could not be found.");
            }
            oldUser.Email = user.Email;
            oldUser.Name = user.Name;
            _userRepository.Update(oldUser);
            await _unitOfWork.CommitAsync(cancellationToken);
            return _mapper.Map<UpdateUserResponse>(oldUser);
        }
    }
}
