using Meetup.Domain.ModelConfigurations;
using Meetup.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Meetup.Persistence.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MSSqlServerMeetupDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfiguration(new MeetingModelConfiguration());
            _ = modelBuilder.ApplyConfiguration(new MeetingTypeModelConfiguration());
            _ = modelBuilder.ApplyConfiguration(new LocationModelConfiguration());
            _ = modelBuilder.ApplyConfiguration(new TagModelConfiguration());
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingType> MeetingTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
