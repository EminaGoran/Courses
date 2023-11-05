using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
    public class DrzaveInsertRequest
    {
        [Required]
        public string Naziv { get; set; } = null!;
    }
}
