using FYT.Application.DTOs.GymSession;
using FYT.Domain.Enums;

namespace FYT.Application.DTOs.Gym
{
    public class GymRequestModel
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public TimeSpan? OpenTime { get; set; }
        public TimeSpan? CloseTime { get; set; }
        public EnumGender Gender { get; set; }
        public TimeSpan? FemaleTime { get; set; }
        public TimeSpan? MaleTime { get; set; }
        public string? ImagePath { get; set; }

        public Guid OwnerId { get; set; }

        public required ICollection<GymSessionRequestModel> GymSessions { get; set; }
    }
}
