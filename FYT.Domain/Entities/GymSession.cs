using FYT.Domain.Enums;

namespace FYT.Domain.Entities
{
    public class GymSession
    {
        public required Gym Gym { get; set; }
        public Guid GymId { get; set; }

        public int Code { get; set; }
        public required string Name { get; set; }
        public required int Price { get; set; }
        public Gender Gender { get; set; }
    }
}
