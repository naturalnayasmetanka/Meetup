using System;

namespace Meetup.Domain.Models
{
    public class MeetingType : Entity<Guid>
    {
        public string Name { get; set; }
    }
}
