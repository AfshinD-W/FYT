using FYT.Domain.Enums;

namespace FYT.Application.DTOs.User
{
    public class User
    {
        public required string Name { get; set; }
        public string? UserName { get; set; }
        public int Age { get; set; }
        public EnumGender Gender { get; set; }
        public string? Email { get; set; }
        public required string Password { get; set; }
        public string? ImagePath { get; set; }

        public required ICollection<int> UserRoles { get; set; }
    }
}
