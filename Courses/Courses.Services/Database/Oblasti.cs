using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Oblasti
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Kursevi> Kursevis { get; set; } = new List<Kursevi>();
}
