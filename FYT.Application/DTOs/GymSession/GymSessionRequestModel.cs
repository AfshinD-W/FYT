using FYT.Domain.Enums;

namespace FYT.Application.DTOs.GymSession
{
    public class GymSessionRequestModel
    {
        public Guid GymId { get; set; }
        public int Code { get; set; }
        public required string Name { get; set; }
        public required int Price { get; set; }
        public Gender Gender { get; set; }
    }
}
