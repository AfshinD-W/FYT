namespace FYT.Domain.Entities
{
    public class UserRoles
    {
        public Guid UserId { get; set; }
        public required User User { get; set; }

        public Guid UserTypeId { get; set; }
        public required UserType UserType { get; set; }
    }
}
