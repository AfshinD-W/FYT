using FYT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FYT.Infrastructure.Configureation
{
    public class GymConfigureation : IEntityTypeConfiguration<Gym>
    {
        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            builder.Property(n => n.Name).HasMaxLength(50);

            builder.Property(x => x.Description).HasMaxLength(1500);

            builder.Property(x => x.Latitude).HasMaxLength(7);

            builder.Property(x => x.Longitude).HasMaxLength(7);

            builder.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<Gym>(x => x.OwnerId);
        }
    }
}
