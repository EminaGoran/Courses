using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.SearchObjects
{
     public class UplateSearchObject:BaseSearchObject
    {
        public int? KorisnikId { get; set; }
        public int? KursId { get; set; }
        public bool? IsKorisniciInclude { get; set; }

        public bool? IsKursInclude { get; set; }

    }
}
