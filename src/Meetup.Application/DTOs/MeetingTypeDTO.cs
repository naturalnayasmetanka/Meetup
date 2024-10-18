using System;

namespace Meetup.Application.DTOs
{
    public class MeetingTypeDTO : EntityDTO<Guid>
    {
        public string Name { get; set; }

        public Guid MeetingId { get; set; }
        public MeetingDTO Meeting { get; set; }
    }
}
