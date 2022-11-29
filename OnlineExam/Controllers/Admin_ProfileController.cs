using Microsoft.AspNetCore.Mvc;
using OnlineExam.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineExam.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Admin_ProfileController : ControllerBase
    {
        OnlineExamContext db = new OnlineExamContext();
        // GET: api/<ValuesController10>
        [HttpGet]
        [Route("AdminProfile")]
        public IActionResult GetAdinProfile()
        {
            var data = db.AdminRegisters.ToList();
            return Ok(data);
        }

        // GET api/<ValuesController8>/5
        [HttpGet()]
        [Route("AdminProfile/{id}")]
        public IActionResult GetAdminProfile(int id)
        {
            var data = db.AdminRegisters.Where(r => r.Adminid == id).FirstOrDefault();

            return Ok(data);
        }

        // POST api/<ValuesController10>
        /*[HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController10>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController10>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
