namespace FYT.Domain.Base
{
    public class BaseEntity<Tkey> where Tkey : struct, IEquatable<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? Creator { get; set; }
        public Guid? Updator { get; set; }
    }
}
