using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
   public class KorisniciInsertRequest
    {
       // public IFormFile ProfilnaFotografija { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string KorisnickoIme { get; set; } = null!;

       
        [Compare("LozinkaPotvrda",ErrorMessage ="Lozinske se ne podudaraju")]
        public string Lozinka {  get; set; } = null!;

        [Compare("Lozinka", ErrorMessage = "Lozinske se ne podudaraju")]
        public string LozinkaPotvrda { get; set; } = null!;
        public DateTime DatumRegistracije { get; set; }

        public DateTime? DatumPosljednjePrijave { get; set; }

        public int GradId { get; set; }

        public int? Uloga { get; set; }

    }
}
