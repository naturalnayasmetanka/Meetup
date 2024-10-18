using System;
using System.Collections.Generic;

namespace Meetup.Domain.Models
{
    public class Meeting : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Guid MeetingTypeId { get; set; }
        public MeetingType MeetingType { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Location> Locations { get; set; }
    }
}
