using System;
using System.Collections.Generic;

namespace Meetup.Application.DTOs
{
    public class LocationDTO : EntityDTO<Guid>
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string RoomNumber { get; set; }

        public List<MeetingDTO> Meetings { get; set; }
    }
}
