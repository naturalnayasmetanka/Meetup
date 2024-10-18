using System;
using System.Collections.Generic;

namespace Meetup.Domain.Models
{
    public class Tag: Entity<Guid>
    {
        public string Name { get; set; }

        public List<Meeting> Meetings { get; set; }
    }
}
