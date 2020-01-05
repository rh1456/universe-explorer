using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace HarryPotterApi.Models
{
  public class Student
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public bool PlaysQuidditch { get; set; }

    public int SchoolHouseId { get; set; }

    public Student Students { get; set; }
  }
}