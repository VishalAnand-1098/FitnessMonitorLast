namespace FitnessMonitor.Data
{
    using FitnessMonitor.Models;
    using Microsoft.EntityFrameworkCore;

    public class FitnessTrackerDbContext : DbContext
    {
        public FitnessTrackerDbContext(DbContextOptions<FitnessTrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserStat> UserStats { get; set; }
    }
}
