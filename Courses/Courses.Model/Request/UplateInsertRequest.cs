using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
  public class UplateInsertRequest
    {
   
        public float Iznos { get; set; }

        public DateTime DatumUplate { get; set; }

        public int? KorisnikId { get; set; }

        public int? KursId { get; set; }

     
    }
}
