using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
   public class Korisnici
    {
        public int Id { get; set; }

        public byte[]? ProfilnaFotografija { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public string Email { get; set; } = null!;

        public Uloga UlogaNavigation { get; set; } = null!;

        public string KorisnickoIme { get; set; } = null!;

        public virtual ICollection<KursKorisnici> KursKorisnicis { get; set; } = new List<KursKorisnici>();


       // public DateTime DatumRegistracije { get; set; }

        //public DateTime? DatumPosljednjePrijave { get; set; }


    }
}
