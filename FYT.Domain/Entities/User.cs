using FYT.Domain.Base;

namespace FYT.Domain.Entities
{
    public class User : BaseEntity<Guid>
    {
        public required string Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public required string Password { get; set; }
        public string? ImagePath { get; set; }

        public required ICollection<UserRoles> UserRoles { get; set; }
    }
}
