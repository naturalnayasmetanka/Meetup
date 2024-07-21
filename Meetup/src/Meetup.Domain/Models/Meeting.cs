using System;
using System.Collections.Generic;

namespace Meetup.Domain.Models
{
    public class Meeting : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }

        public Guid LocationId { get; set; }
        public Location Location { get; set; }

        public MeetingType MeetingType { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
