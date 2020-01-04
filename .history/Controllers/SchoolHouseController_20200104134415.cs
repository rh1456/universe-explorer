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
  }
}