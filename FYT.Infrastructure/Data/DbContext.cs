using FYT.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FYT.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Gym> Gyms { get; set; }
        public DbSet<GymSession> GymSessions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}
