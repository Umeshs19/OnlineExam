using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineExam.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineExam.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class User_ProfileController : ControllerBase
    {
        OnlineExamContext db = new OnlineExamContext();
        // GET: api/<ValuesController8>
        [HttpGet]
        [Route("UserProfile")]
        public IActionResult GetUserProfile()
        {
            var data = db.Registration.ToList();
            return Ok(data);
        }

        // GET api/<ValuesController8>/5
        [HttpGet]
        [Route("UserProfile/{id}")]
        public IActionResult GetUserProfile(int id)
        {
            var data = db.Registration.Where(r => r.UserId==id).FirstOrDefault();

            return Ok(data);
        }


        /*// POST api/<ValuesController8>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController8>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController8>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
