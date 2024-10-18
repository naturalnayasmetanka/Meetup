using System;
using System.Collections.Generic;

namespace Meetup.Application.DTOs
{
    public class MeetingDTO : EntityDTO<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Guid MeetingTypeId { get; set; }
        public MeetingTypeDTO MeetingType { get; set; }
        public List<TagDTO> Tags { get; set; }
        public List<LocationDTO> Locations { get; set; }
    }
}
