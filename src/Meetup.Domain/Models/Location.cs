using System;
using System.Collections.Generic;

namespace Meetup.Domain.Models
{
    public class Location : Entity<Guid>
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string RoomNumber { get; set; }

        public List<Meeting> Meetings { get; set; }
    }
}
