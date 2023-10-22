using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Uloga
{
    public int UlogaId { get; set; }

    public string? Naziv { get; set; }

    public string? Opis { get; set; }

    public virtual ICollection<Korisnici> Korisnicis { get; set; } = new List<Korisnici>();
}
