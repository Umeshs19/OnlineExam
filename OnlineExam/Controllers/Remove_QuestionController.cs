using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExam.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ProjectDb.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Remove_QuestionController : ControllerBase
    {
        OnlineExamContext db = new OnlineExamContext();
        [HttpGet]
        [Route("QList")]
        public ActionResult GetQuestion(int questionId)
        {
            var data = from d in db.QuestionBanks select d;
            return Ok(data);
        }
        [HttpGet]
        [Route("QList/{id}")]
        public ActionResult GetQuestion(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id cannot be found");
            }
            var data = (from d in db.QuestionBanks where d.QuestionId == id select d).FirstOrDefault();

            if (data == null)
            {
                return NotFound($"Question {id} not present");
            }
            return Ok(data);
        }
        [HttpDelete]
        [Route("DeleteQuestion/{id}")]
        public IActionResult DeleteQuestion(int id)
        {
            try
            {
                var data = db.QuestionBanks.Find(id);
                db.QuestionBanks.Remove(data);
                db.SaveChanges();
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }
    }
}