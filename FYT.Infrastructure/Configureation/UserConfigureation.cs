using FYT.Application.DTOs.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FYT.Infrastructure.Configureation
{
    public class UserConfigureation : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.Property(x => x.UserName).HasMaxLength(50);

            builder.Property(x => x.Password).HasMaxLength(226);
        }
    }
}
