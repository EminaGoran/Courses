using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
    public class TipMaterijala
    {
        public int Id { get; set; }

        public string Naziv { get; set; } = null!;

        public virtual ICollection<Materijali> Materijalis { get; set; } = new List<Materijali>();
    }
}
