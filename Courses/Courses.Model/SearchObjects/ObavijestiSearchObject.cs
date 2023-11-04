using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.SearchObjects
{
    public class ObavijestiSearchObject:BaseSearchObject
    {
        public DateTime? DatumObjave { get; set; }
        public string? Naziv { get; set; } = null!;

        public int? TipObavijestiId { get; set; }

    }
}
