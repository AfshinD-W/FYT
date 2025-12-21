using FYT.Domain.Base;

namespace FYT.Application.DTOs.User
{
    public class User : BaseEntity<Guid>
    {
        public required string Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public required string Password { get; set; }
        public string? ImagePath { get; set; }

        public required ICollection<int> UserRoles { get; set; }
    }
}
