using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Medication
    {
        public int Id { get; set; }
        public virtual Visit Visit { get; set; }
        public string Name { get; set; }
        public string PerDay { get; set; }
        public DateTime Durratin { get; set; }

    }
}
