using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public string Name { get; set; }
    public DateTime DateHired { get; set; }
    public string Specialties { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
    public int StylistId { get; set; }
  }
}
