using FYT.Domain.Base;

namespace FYT.Domain.Interfaces
{
    public interface IRepository<Tkey, Tentity> where Tkey : struct, IEquatable<Tkey> where Tentity : BaseEntity<Tkey>
    {
        Task<Tentity> GetAsync(Tkey id);
        Task<ICollection<Tentity>> GetAllAsync();

        Task<Tentity> CreateAsync(Tentity entity);
        Task<ICollection<Tentity>> BulkCreateAsync(IEnumerable<Tentity> entities);

        Task<Tentity> UpdateAsync(Tentity entity);
        Task<ICollection<Tentity>> BulkUpdateAsync(IEnumerable<Tentity> entities);

        Task<bool> DeleteAsync(Tkey id);
        Task<int> BulkDeleteAsync(IEnumerable<Tkey> ids);
    }
}
