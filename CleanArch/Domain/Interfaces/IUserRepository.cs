using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> GetByEmailAsync(string email,CancellationToken cancellationToken);
    }
}
