using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
    
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Report_CardController : ControllerBase
    {
        // GET: api/<ValuesController7>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController7>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController7>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController7>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController7>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
