namespace Courses.Model
{
    public class Kurs
    {
        public int Id { get; set; }

        public byte[]? Ikona { get; set; }

        public string Naziv { get; set; } = null!;

        public string Opis { get; set; } = null!;

        public int BrojSati { get; set; }

        public int Cijena { get; set; }

        public DateTime DatumPocetka { get; set; }

        public DateTime DatumZavrsetka { get; set; }

        public int OblastId { get; set; }

    }
}