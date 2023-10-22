using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Uplate
{
    public int Id { get; set; }

    public float Iznos { get; set; }

    public DateTime DatumUplate { get; set; }

    public int? KorisnikId { get; set; }

    public int? KursId { get; set; }

    public virtual Korisnici? Korisnik { get; set; }

    public virtual Kursevi? Kurs { get; set; }
}
