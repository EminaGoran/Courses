using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Drzave
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Gradovi> Gradovis { get; set; } = new List<Gradovi>();
}
