using System.Collections.Generic;
using System;
using System.Linq;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public DateTime DateHired { get; set; }
    public string Specialties { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

  }
}
