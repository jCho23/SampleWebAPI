using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;
using System.Collections.ObjectModel;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            var list = new List<Message>();

            Message firstMessage = new Message();

            firstMessage.OriginalMessage = "Its good!";

            list.Add(firstMessage);

            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int userId)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
