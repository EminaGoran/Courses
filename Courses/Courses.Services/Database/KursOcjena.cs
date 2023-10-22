using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class KursOcjena
{
    public int KursOcjenaId { get; set; }

    public int? KursId { get; set; }

    public int? OcjenaId { get; set; }

    public virtual Kursevi KursOcjenaNavigation { get; set; } = null!;

    public virtual Ocjena? Ocjena { get; set; }
}
