﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model.SearchObjects
{
    public class GradSearchObject:BaseSearchObject
    {
        public string? Naziv { get; set; } = null!;

        public string? PostanskiBroj { get; set; } = null!;
    }
}