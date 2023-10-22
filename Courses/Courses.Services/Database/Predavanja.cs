using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Predavanja
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string Opis { get; set; } = null!;

    public DateTime DatumPredavanja { get; set; }

    public int KursId { get; set; }

    public virtual Kursevi Kurs { get; set; } = null!;

    public virtual ICollection<KursKorisnici> KursKorisnicis { get; set; } = new List<KursKorisnici>();

    public virtual ICollection<Prisustva> Prisustvas { get; set; } = new List<Prisustva>();
}
