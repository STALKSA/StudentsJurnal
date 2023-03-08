using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalDB.Entity
{
    public class Group
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }     

        public List<Student>? Students { get; set; }

        public int? StudentCount => Students?.Count;

        public override string ToString()
        {
            return $"{Name} ({StudentCount})";
        }

    }
}
