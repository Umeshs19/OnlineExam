using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using OnlineExam.Models;

namespace onlineproject.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        OnlineExamContext db = new OnlineExamContext();
        [HttpGet]

        public ActionResult get()
        {
            var data = db.Logins.ToList();
            return Ok(data);
        }


        [HttpPost]
        [Route("Authenticate")]

        public ActionResult<Registration> Authenticate(Registration l)
        {
            var data = db.Logins.Where(u => (u.Email == l.Email) && (u.Password == l.Password));

            if (data == null)
            {
                return NotFound("no matched");
            }

            return Ok();
        }


    }
}




