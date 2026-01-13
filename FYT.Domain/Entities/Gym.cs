using FYT.Domain.Base;
using FYT.Domain.Enums;

namespace FYT.Domain.Entities
{
    public class Gym : BaseEntity<Guid>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public TimeSpan? OpenTime { get; set; }
        public TimeSpan? CloseTime { get; set; }
        public Gender Gender { get; set; }
        public TimeSpan? FemaleTime { get; set; }
        public TimeSpan? MaleTime { get; set; }
        public string? ImagePath { get; set; }

        public required User User { get; set; }
        public Guid OwnerId { get; set; }

        public required ICollection<GymSession> GymSessions { get; set; }
    }
}
