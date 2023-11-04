using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
 public class MaterijaliInsertRequest
    {


        public string? Naziv { get; set; }

        public int KursId { get; set; }

        public int TipMaterijalaId { get; set; }

        public byte[]? File { get; set; }

        public DateTime DatumObjave { get; set; }

       
    }
}
