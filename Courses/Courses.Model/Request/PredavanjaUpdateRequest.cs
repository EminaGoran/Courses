﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.Request
{
 public class PredavanjaUpdateRequest
    {
        public string? Naziv { get; set; } = null!;

        public string? Opis { get; set; } = null!;

        public DateTime? DatumPredavanja { get; set; }

    

    }
}
