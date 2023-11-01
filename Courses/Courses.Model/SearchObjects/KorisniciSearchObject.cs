using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.SearchObjects
{
public class KorisniciSearchObject:BaseSearchObject
    {
        public bool? IsUlogaIncluded { get; set; }
        public bool? IsKursIncluded { get; set; }

    }
}
