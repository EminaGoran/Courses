using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Kursevi
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

    public virtual ICollection<KursKorisnici> KursKorisnicis { get; set; } = new List<KursKorisnici>();

    public virtual KursOcjena? KursOcjena { get; set; }

    public virtual ICollection<Materijali> Materijalis { get; set; } = new List<Materijali>();

    public virtual ICollection<Obavijesti> Obavijestis { get; set; } = new List<Obavijesti>();

    public virtual Oblasti Oblast { get; set; } = null!;

    public virtual ICollection<Predavanja> Predavanjas { get; set; } = new List<Predavanja>();

    public virtual ICollection<Uplate> Uplates { get; set; } = new List<Uplate>();
}
