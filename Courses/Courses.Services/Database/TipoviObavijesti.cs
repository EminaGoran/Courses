using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class TipoviObavijesti
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Obavijesti> Obavijestis { get; set; } = new List<Obavijesti>();
}
