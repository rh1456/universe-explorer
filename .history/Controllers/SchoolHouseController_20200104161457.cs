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
      if (schoolhouse == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(schoolhouse);
      }
    }
    [HttpPost]
    public ActionResult CreateSchoolHouse(SchoolHouse schoolhouse)
    {
      var db = new DatabaseContext();
      db.SchoolHouses.Add(schoolhouse);
      db.SaveChanges();
      return Ok(schoolhouse);
    }
    [HttpPut("{id}")]
    public ActionResult UpdateSchoolHouse(SchoolHouse schoolhouse)
    {
      var db = new DatabaseContext();
      var prevSchoolHouse = db.SchoolHouses.FirstOrDefault(schoolhouse => schoolhouse.Id == id);
      if (prevSchoolHouse == null)
      {
        return NotFound();
      }
      else
      {
        prevSchoolHouse.HouseName = schoolhouse.HouseName;
        prevSchoolHouse.Color = schoolhouse.Color;
      }
    }
  }
}