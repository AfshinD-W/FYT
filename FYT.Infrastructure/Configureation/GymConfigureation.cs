using FYT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FYT.Infrastructure.Configureation
{
    public class GymConfigureation : IEntityTypeConfiguration<Gym>
    {
        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            builder.Property(n => n.Name).HasMaxLength(68);

            //Set max len for this property
            builder.Property(x => x.Description);

            builder.Property(x => x.Latitude).HasMaxLength(7);

            builder.Property(x => x.Longitude).HasMaxLength(7);

            builder.HasOne(x => x.User).WithOne().HasForeignKey<Gym>(x => x.OwnerId);
        }
    }
}
