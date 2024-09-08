using System;

namespace Meetup.Domain.Models
{
    public class MeetingType : Entity
    {
        public string Name { get; set; }

        public Guid MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}
