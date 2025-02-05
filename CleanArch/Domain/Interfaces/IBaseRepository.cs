using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(Guid id,CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
        void AddAsync(T entity);
        void UpdateAsync(T entity);
        void RemoveAsync(T entity);
    }
}
