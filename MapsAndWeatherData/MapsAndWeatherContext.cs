using MapsAndWeatherData.Models;
using Microsoft.EntityFrameworkCore;

namespace MapsAndWeatherData
{
    public class MapsAndWeatherContext : DbContext
    {
        public MapsAndWeatherContext(DbContextOptions<MapsAndWeatherContext> options) : base(options)
        {
        }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MapsAndWeatherContext).Assembly);
        }
    }
}
