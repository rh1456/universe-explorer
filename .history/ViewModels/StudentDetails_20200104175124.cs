using System.Collections.Generic;

namespace HarryPotterApi.ViewModels
{
  public class StudentDetails
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public bool PlaysQuidditch { get; set; }
    public string HouseAffiliation { get; set; }

    public List<SchoolHouseViewModel> SchoolHouses { get; set; }
      = new List<SchoolHouseViewModel>();

  }
}