namespace HarryPotterApi.ViewModels
{
  public class SchoolHouseViewModel
  {
    public int Id { get; set; }
    public string HouseName { get; set; }
    public string Color { get; set; }

    public List<Student> students { get; set; }
      = new List<Student>();

  }
}