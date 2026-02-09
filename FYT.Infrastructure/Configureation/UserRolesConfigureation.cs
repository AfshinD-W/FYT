using FYT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FYT.Infrastructure.Configureation
{
    public class UserRolesConfigureation : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.HasKey(x => new { x.UserId, x.UserTypeId });

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.UserId);


            builder.HasOne(x => x.UserType)
                   .WithMany(x => x.UserRoles)
                   .HasForeignKey(x => x.UserTypeId);
        }
    }
}
