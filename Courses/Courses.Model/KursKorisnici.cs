using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
    public class KursKorisnici
    {
        public int KursId { get; set; }

        public int KorisnikId { get; set; }

        public int? PredavanjeId { get; set; }

        public bool? Certifikat { get; set; }

        public bool? Polozio { get; set; }

        //public virtual Korisnici Korisnik { get; set; } = null!;
        public virtual Kurs Kurs { get; set; } = null!;


        //public virtual Kursevi Kurs { get; set; } = null!;

        //public virtual Predavanja? Predavanje { get; set; }

        //public virtual ICollection<Prisustva> Prisustvas { get; set; } = new List<Prisustva>();
    }
}
