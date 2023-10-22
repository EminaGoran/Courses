using System;
using System.Collections.Generic;

namespace Courses.Services.Database;

public partial class Materijali
{
    public int Id { get; set; }

    public string? Naziv { get; set; }

    public int KursId { get; set; }

    public int TipMaterijalaId { get; set; }

    public byte[]? File { get; set; }

    public DateTime DatumObjave { get; set; }

    public virtual Kursevi Kurs { get; set; } = null!;

    public virtual ICollection<MaterijalOcjena> MaterijalOcjenas { get; set; } = new List<MaterijalOcjena>();

    public virtual TipMaterijala TipMaterijala { get; set; } = null!;
}
