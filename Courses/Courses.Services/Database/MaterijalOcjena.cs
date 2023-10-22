using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class MaterijalOcjena
{
    public int MaterijalOcjenaId { get; set; }

    public int? MaterijalId { get; set; }

    public int? OcjenaId { get; set; }

    public virtual Materijali? Materijal { get; set; }

    public virtual Ocjena? Ocjena { get; set; }
}
