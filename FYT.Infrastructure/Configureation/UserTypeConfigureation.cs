using FYT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FYT.Infrastructure.Configureation
{
    public class UserTypeConfigureation : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
