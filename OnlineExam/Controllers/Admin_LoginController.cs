using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExam.Models;
using System.Linq;

namespace onlineproject.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class AdminLoginController : ControllerBase
    {
        OnlineExamContext db = new OnlineExamContext();

        [HttpGet]

        public ActionResult GetAdminLogin()
        {
            var data = db.AdminLogins.ToList();
            return Ok(data);
        }


        [HttpPost]
        [Route("Authenticate")]

        public ActionResult<Registration> Authenticate(Registration l)
        {
            var data = (db.Logins.Where(u => (u.Email == l.Email) && (u.Password == l.Password))).FirstOrDefault();

            if (data == null)
            {
                return NotFound("no matched");
            }

            return Ok();
        }


    }
}


