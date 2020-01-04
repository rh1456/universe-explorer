using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HarryPotterApi.Models;

namespace HarryPotterApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SchoolHouseController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllHouses()
    {
      var db = new DatabaseContext();
      return Ok(db.SchoolHouses);
    }
    [HttpGet("{id}")]
    public ActionResult GetOneHouse(int id)
    {
      var db = new DatabaseContext();
      var schoolhouse = db.SchoolHouses.FirstOrDefault(schoolhouse => schoolhouse.Id == id);
      if (Student == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(student);
      }
    }
  }
}