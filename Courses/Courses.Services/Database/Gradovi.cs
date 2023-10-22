using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Gradovi
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string PostanskiBroj { get; set; } = null!;

    public int DrzavaId { get; set; }

    public virtual Drzave Drzava { get; set; } = null!;

    public virtual ICollection<Korisnici> Korisnicis { get; set; } = new List<Korisnici>();
}
