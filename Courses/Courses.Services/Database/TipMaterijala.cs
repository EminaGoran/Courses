using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class TipMaterijala
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Materijali> Materijalis { get; set; } = new List<Materijali>();
}
