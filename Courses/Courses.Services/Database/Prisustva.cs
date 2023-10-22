using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Prisustva
{
    public int Id { get; set; }

    public int PredavanjeId { get; set; }

    public int KursKorisnikId { get; set; }

    public string? Napomena { get; set; }

    public bool Prisutan { get; set; }

    public virtual KursKorisnici KursKorisnik { get; set; } = null!;

    public virtual Predavanja Predavanje { get; set; } = null!;
}
