using System;
using System.Collections.Generic;

namespace Meetup.Application.DTOs
{
    public class TagDTO : EntityDTO<Guid>
    {
        public string Name { get; set; }

        public List<MeetingDTO> Meetings { get; set; }
    }
}
