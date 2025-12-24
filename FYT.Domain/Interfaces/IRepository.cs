using FYT.Domain.Base;

namespace FYT.Domain.Interfaces
{
    public interface IRepository<TKey, TEntity> where TKey : struct, IEquatable<TKey> where TEntity : BaseEntity<TKey>
    {
        Task<TEntity?> GetAsync(TKey id);
        Task<ICollection<TEntity>> GetAllAsync();

        Task AddAsync(TEntity entity);
        Task BulkAddAsync(IEnumerable<TEntity> entities);

        Task UpdateAsync(TEntity entity);
        Task BulkUpdateAsync(IEnumerable<TEntity> entities);

        Task DeleteAsync(TEntity entity);
        Task BulkDeleteAsync(IEnumerable<TEntity> entities);
    }
}
