using System;

namespace Meetup.Application.DTOs
{
    internal class MeetingTypeDTO : EntityDTO<Guid>
    {
        public string Name { get; set; }
    }
}
