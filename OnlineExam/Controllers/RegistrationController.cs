using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System;
using OnlineExam.Models;

namespace onlineproject.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        OnlineExamContext db = new OnlineExamContext();
        [HttpGet]
        [Route("listreg")]
        public IActionResult GetRegistration()
        {
            var data = db.Registration.ToList();
            return Ok(data);
        }
        [HttpPost]
        [Route("Addreg")]
        public IActionResult PostRegistration(Registration registration)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Registration.Add(registration);
                    db.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Created("Record Successfully Added", registration);
        }
    }
}