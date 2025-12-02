using MapsAndWeatherData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MapsAndWeatherData.Configuration
{
    internal class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.ToTable("Settings");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Value).IsRequired().HasMaxLength(500);
            builder.HasIndex(s => s.Name).IsUnique().IncludeProperties(s => s.Value);
        }         
    }
}
