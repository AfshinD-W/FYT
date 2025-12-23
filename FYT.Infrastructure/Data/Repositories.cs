using FYT.Domain.Base;
using FYT.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FYT.Infrastructure.Data
{
    public class Repository<Tkey, Tentity> : IRepository<Tkey, Tentity> where Tkey : struct, IEquatable<Tkey> where Tentity : BaseEntity<Tkey>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Tentity> _dbSet;

        public Repository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _dbSet = _context.Set<Tentity>();
        }

        #region Get

        public async Task<Tentity> GetAsync(Tkey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<ICollection<Tentity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        #endregion

        #region Create
        public async Task<Tentity> CreateAsync(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Tentity>> BulkCreateAsync(IEnumerable<Tentity> entities)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Update

        public Task<ICollection<Tentity>> BulkUpdateAsync(IEnumerable<Tentity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Tentity> UpdateAsync(Tentity entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task<bool> DeleteAsync(Tkey id)
        {
            throw new NotImplementedException();
        }

        public Task<int> BulkDeleteAsync(IEnumerable<Tkey> ids)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
