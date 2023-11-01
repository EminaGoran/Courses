using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
    public class Uloga
    {
        
            public int UlogaId { get; set; }

            public string? Naziv { get; set; }

            public string? Opis { get; set; }

            //public virtual ICollection<Korisnici> Korisnicis { get; set; } = new List<Korisnici>();
       
    }
}
