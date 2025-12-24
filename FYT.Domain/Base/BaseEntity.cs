namespace FYT.Domain.Base
{
    public class BaseEntity<TKey> where TKey : struct, IEquatable<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? Creator { get; set; }
        public Guid? Updator { get; set; }
    }
}
