using System;

namespace Meetup.Application.DTOs
{
    public class MeetingTypeDTO : EntityDTO<Guid>
    {
        public string Name { get; set; }
    }
}
