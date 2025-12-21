namespace FYT.Application.DTOs.User
{
    public class UserResponseModel
    {
        public required string Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public required string Password { get; set; }
        public string? ImagePath { get; set; }

        public required ICollection<int> UserRoles { get; set; }
    }
}
