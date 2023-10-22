using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class PredavacOcjena
{
    public int PredavacOcjenaId { get; set; }

    public int? OcjenaId { get; set; }

    public int? PredavacId { get; set; }

    public virtual Ocjena? Ocjena { get; set; }

    public virtual Korisnici? Predavac { get; set; }
}
