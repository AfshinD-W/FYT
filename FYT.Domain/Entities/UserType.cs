using FYT.Domain.Base;

namespace FYT.Domain.Entities
{
    public class UserType : BaseEntity<Guid>
    {
        public int Code { get; set; }
        public required string Name { get; set; }
    }
}
