using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
  public class ObavijestiUpdateRequest
    {
   

        public byte[]? NaslovnaFotografija { get; set; } = null!;

        public string Naziv { get; set; } = null!;

        public string Opis { get; set; } = null!;

        public string KratakOpis { get; set; } = null!;

 

        public DateTime DatumAzuriranja { get; set; }

        public byte[]? Dodatak { get; set; }

        public string? DodatakNaziv { get; set; }


    }
}
