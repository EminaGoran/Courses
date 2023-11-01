using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
   public class GradInsertRequest
    {
        public string Naziv { get; set; } = null!;

        public string PostanskiBroj { get; set; } = null!;

        public int DrzavaId { get; set; }
    }
}
