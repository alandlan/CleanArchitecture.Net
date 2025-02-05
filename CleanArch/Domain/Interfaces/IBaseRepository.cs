using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(Guid id,CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
