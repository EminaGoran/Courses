using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Korisnici
{
    public int Id { get; set; }

    public byte[]? ProfilnaFotografija { get; set; }

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string KorisnickoIme { get; set; } = null!;

    public string LozinkaHash { get; set; } = null!;

    public string LozinkaSalt { get; set; } = null!;

    public DateTime DatumRegistracije { get; set; }

    public DateTime? DatumPosljednjePrijave { get; set; }

    public int GradId { get; set; }

    public int? Uloga { get; set; }

    public virtual Gradovi Grad { get; set; } = null!;

    public virtual ICollection<KursKorisnici> KursKorisnicis { get; set; } = new List<KursKorisnici>();

    public virtual ICollection<PredavacOcjena> PredavacOcjenas { get; set; } = new List<PredavacOcjena>();

    public virtual Uloga? UlogaNavigation { get; set; }

    public virtual ICollection<Uplate> Uplates { get; set; } = new List<Uplate>();
}
