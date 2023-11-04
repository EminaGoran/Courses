using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
    public class Obavijesti
    {
        public int Id { get; set; }

        public byte[]? NaslovnaFotografija { get; set; } = null!;

        public string Naziv { get; set; } = null!;

        public string Opis { get; set; } = null!;

        public string KratakOpis { get; set; } = null!;

        public DateTime DatumObjave { get; set; }

        public DateTime DatumAzuriranja { get; set; }

        public byte[]? Dodatak { get; set; }

        public string? DodatakNaziv { get; set; }

        public int TipObavijestiId { get; set; }

        public int? KursId { get; set; }

        //public virtual Kursevi? Kurs { get; set; }

        //public virtual TipoviObavijesti TipObavijesti { get; set; } = null!;
    }
}
