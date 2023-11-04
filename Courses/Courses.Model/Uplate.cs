using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
public class Uplate
    {
        public int Id { get; set; }

        public float Iznos { get; set; }

        public DateTime DatumUplate { get; set; }

        public int? KorisnikId { get; set; }

        public int? KursId { get; set; }

        public virtual Korisnici? Korisnik { get; set; }

        public virtual Kurs? Kurs { get; set; }
    }
}
