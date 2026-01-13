using FYT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FYT.Infrastructure.Configureation
{
    public class GymSessionsConfigureation : IEntityTypeConfiguration<GymSession>
    {
        public void Configure(EntityTypeBuilder<GymSession> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
