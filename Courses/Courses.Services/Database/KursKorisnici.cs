using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class KursKorisnici
{
    public int Id { get; set; }

    public int KursId { get; set; }

    public int KorisnikId { get; set; }

    public int? PredavanjeId { get; set; }

    public bool? Certifikat { get; set; }

    public bool? Polozio { get; set; }

    public virtual Korisnici Korisnik { get; set; } = null!;

    public virtual Kursevi Kurs { get; set; } = null!;

    public virtual Predavanja? Predavanje { get; set; }

    public virtual ICollection<Prisustva> Prisustvas { get; set; } = new List<Prisustva>();
}
