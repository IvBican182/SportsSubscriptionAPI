using Microsoft.EntityFrameworkCore;

namespace SportsSubscriptionAPI.Data
{
    public class SportsSubscriptionDbContext : DbContext
    {
        public SportsSubscriptionDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team > Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "NK Neretva"

                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Bićanić",
                    Role = "admin",
                    Email = "ibicanic@live.com",
                    TeamId = 1
                    


                }
            );
        }
    }
}
