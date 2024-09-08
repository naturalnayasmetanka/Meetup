using Meetup.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Meetup.Domain.ModelConfigurations
{
    public class TagModelConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable(nameof(Tag)).HasKey(k => k.Id);
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasMany(x => x.Meetings)
                .WithMany(x => x.Tags);
        }
    }
}
