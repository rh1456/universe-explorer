using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HarryPotterApi.Models;
using HarryPotterApi.ViewModels;

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
    [HttpGet("{id}")]
    public ActionResult GetOneStudent(int id)
    {
      var db = new DatabaseContext();
      var student = db.Students.FirstOrDefault(student => student.Id == id);
      if (student == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(student);
      }
    }
    [HttpPost]
    public ActionResult CreateStudent(NewStudent viewModel)
    {
      var db = new DatabaseContext();
      var schoolhouse = db.SchoolHouses
        .FirstOrDefault(schoolhouse => schoolhouse.Id == viewModel.SchoolHouseId);
      if (schoolhouse == null)
      {
        return NotFound();
      }
      else
      {
        var student = new Student
        {
          FullName = viewModel.FullName,
          PlaysQuidditch = viewModel.PlaysQuidditch,
          SchoolHouseId = viewModel.SchoolHouseId
        };
      }
    }

    [HttpPut("{id}")]
    public ActionResult UpdateStudent(Student student)
    {
      var db = new DatabaseContext();
      var prevStudent = db.Students.FirstOrDefault(student => student.Id == student.Id);
      if (prevStudent == null)
      {
        return NotFound();
      }
      else
      {
        prevStudent.FullName = student.FullName;
        prevStudent.PlaysQuidditch = student.PlaysQuidditch;
        db.SaveChanges();
        return Ok(prevStudent);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult DeleteStudent(int id)
    {
      var db = new DatabaseContext();
      var student = db.Students.FirstOrDefault(student => student.Id == student.Id);
      if (student == null)
      {
        return NotFound();
      }
      else
      {
        db.Students.Remove(student);
        db.SaveChanges();
        return Ok();
      }
    }
  }
}


