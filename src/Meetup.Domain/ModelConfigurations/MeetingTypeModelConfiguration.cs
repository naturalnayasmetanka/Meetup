using Meetup.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Meetup.Domain.ModelConfigurations
{
    public class MeetingTypeModelConfiguration : IEntityTypeConfiguration<MeetingType>
    {
        public void Configure(EntityTypeBuilder<MeetingType> builder)
        {
            builder.ToTable(nameof(MeetingType)).HasKey(k => k.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
           
            builder.HasOne(x => x.Meeting)
                .WithOne(x => x.MeetingType)
                .HasForeignKey<Meeting>(x => x.MeetingTypeId);
        }
    }
}
