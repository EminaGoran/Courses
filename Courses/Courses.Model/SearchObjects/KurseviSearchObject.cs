﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.SearchObjects
{
  public class KurseviSearchObject:BaseSearchObject
    {
        public string? Naziv { get; set; }
        public string? Opis { get; set; }
    }
}
