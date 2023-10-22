using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Ocjena
{
    public int OcjenaId { get; set; }

    public int? Vrijednost { get; set; }

    public string? Opis { get; set; }

    public virtual ICollection<KursOcjena> KursOcjenas { get; set; } = new List<KursOcjena>();

    public virtual ICollection<MaterijalOcjena> MaterijalOcjenas { get; set; } = new List<MaterijalOcjena>();

    public virtual ICollection<PredavacOcjena> PredavacOcjenas { get; set; } = new List<PredavacOcjena>();
}
