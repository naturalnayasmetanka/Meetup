using System;

namespace Meetup.Domain.Models
{
    public class Tag: Entity<Guid>
    {
        public string Name { get; set; }
    }
}
