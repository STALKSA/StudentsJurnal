using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalDB.Entity
{
    public class Visit
    {
        public Guid Id { get; init; }
        public DateTime Date { get; init; }
        public Student? Student { get; init; }   
        
    }
}
