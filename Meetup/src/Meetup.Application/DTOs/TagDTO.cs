using System;

namespace Meetup.Application.DTOs
{
    public class TagDTO: EntityDTO<Guid>
    {
        public string Name { get; set; }
    }
}
