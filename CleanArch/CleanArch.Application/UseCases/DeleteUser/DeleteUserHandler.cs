using CleanArch.Application.Shared.Exceptions;
using CleanArch.Domain.Interfaces;
using MediatR;

namespace CleanArch.Application.UseCases.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteUserHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            _userRepository.Remove(user);
            await _unitOfWork.CommitAsync(cancellationToken);
            return new DeleteUserResponse(request.Id);
        }
    }
}
