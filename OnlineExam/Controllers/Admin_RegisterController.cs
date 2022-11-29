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
    public class AdminRegisterController : Controller
    {
        OnlineExamContext db = new OnlineExamContext();
        [HttpGet]
        [Route("Listadmin")]
        public IActionResult GetAdminRegister()
        {
            var data = db.AdminRegisters.ToList();
            return Ok(data);
        }

        [HttpPost]
        [Route("Addadmin")]
        public IActionResult PostRegistration(AdminRegister adminRegister)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.AdminRegisters.Add(adminRegister);
                    db.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Created("Record Successfully Added", adminRegister);
        }
    }
}

