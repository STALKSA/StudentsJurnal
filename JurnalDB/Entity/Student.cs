﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalDB.Entity
{
    public class Student
    {
        public Guid Id { get; init; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime Birthday { get; set;}

        public Group? Group { get; set;}

        public List<Visit>? Visits { get; set; }

        public int? VisitsCount => Visits?.Count;

        public override string ToString() => Name;

    }
}
