using FYT.Domain.Base;
using FYT.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FYT.Infrastructure.Data
{
    public class Repository<TKey, TEntity> : IRepository<TKey, TEntity> where TKey : struct, IEquatable<TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _dbSet = _context.Set<TEntity>();
        }

        #region Get

        public async Task<TEntity?> GetAsync(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        #endregion

        #region Create
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task BulkAddAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        #endregion

        #region Update

        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task BulkUpdateAsync(IEnumerable<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        #endregion

        #region Delete

        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task BulkDeleteAsync(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        #endregion
    }
}
