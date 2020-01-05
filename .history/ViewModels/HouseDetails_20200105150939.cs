using System.Collections.Generic;

namespace HarryPotterApi.Models
{
  public class HouseDetails
  {
    public int Id { get; set; }
    public string HouseName { get; set; }
    public string Color { get; set; }

    public List<Student> Students { get; set; }
      = new List<Student>();

  }
}