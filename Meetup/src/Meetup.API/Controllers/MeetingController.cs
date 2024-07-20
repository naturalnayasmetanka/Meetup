﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Meetup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        // GET: api/<MeetingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MeetingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MeetingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MeetingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MeetingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
