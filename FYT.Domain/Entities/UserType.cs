using FYT.Domain.Base;

namespace FYT.Domain.Entities
{
    public class UserType : BaseEntity<int>
    {
        public required string Name { get; set; }

        public required ICollection<UserRoles> UserRoles { get; set; }
    }
}
