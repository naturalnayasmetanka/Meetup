using Meetup.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Meetup.Domain.ModelConfigurations
{
    public class LocationModelConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable(nameof(Location)).HasKey(k => k.Id);

            builder.Property(x => x.Country).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(50);
            builder.Property(x => x.Street).HasMaxLength(50);
            builder.Property(x => x.HouseNumber).HasMaxLength(10);
            builder.Property(x => x.RoomNumber).HasMaxLength(10);

            builder.HasMany(x => x.Meetings)
                .WithMany(x => x.Locations);
        }
    }
}
