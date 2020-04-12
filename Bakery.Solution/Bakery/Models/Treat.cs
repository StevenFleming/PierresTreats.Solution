using System.Collections.Generic;
namespace Bakery.Models
{
  public class Treat
  {

    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public string Description { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }
  }
}