using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HarryPotterApi.Models;

namespace HarryPotterApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllStudent()
    {
      var db = new DatabaseContext();
      return Ok(db.Students);
    }
  }
}

