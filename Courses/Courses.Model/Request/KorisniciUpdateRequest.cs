using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
    public class KorisniciUpdateRequest
    {
        // public IFormFile ProfilnaFotografija { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string KorisnickoIme { get; set; } = null!;


        public string Lozinka { get; set; } = null!;
     
    }
}
