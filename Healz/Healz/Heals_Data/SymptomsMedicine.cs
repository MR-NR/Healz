using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class SymptomsMedicine
    {
        public int Id { get; set; }
        public virtual Symptoms Symptoms { get; set; }
        public string Name { get; set; }
        public string Garde { get; set; }
        public string Company { get; set; }
        public string Form { get; set; }
        public string Formula { get; set; }

    }
}
