using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace HarryPotterApi.Models
{
  public class SchoolHouse
  {
    public int Id { get; set; }
    public string HouseName { get; set; }
    public string Color { get; set; }

    public List<AllStudent> AllStudents { get; set; }
      = new List<AllStudent>();

  }

}