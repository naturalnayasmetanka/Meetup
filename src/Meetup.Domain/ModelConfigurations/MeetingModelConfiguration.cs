using Meetup.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Meetup.Domain.ModelConfigurations
{
    public class MeetingModelConfiguration : IEntityTypeConfiguration<Meeting>
    {
        public void Configure(EntityTypeBuilder<Meeting> builder)
        {
            builder.ToTable(nameof(Meeting)).HasKey(k => k.Id);

            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(300);

            builder.HasMany(x => x.Tags)
                .WithMany(x => x.Meetings);

            builder.HasOne(x => x.MeetingType)
                .WithOne(x => x.Meeting)
                .HasForeignKey<MeetingType>(x => x.MeetingId);

            builder.HasMany(x => x.Locations)
                .WithMany(x => x.Meetings);

        }
    }
}
