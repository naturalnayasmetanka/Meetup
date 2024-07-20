using System;

namespace Meetup.Domain.Models
{
    public class Meeting : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
    }
}
