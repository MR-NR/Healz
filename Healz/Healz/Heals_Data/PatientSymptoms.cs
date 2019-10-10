using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class PatientSymptoms
    {
        public int Id { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual Symptoms  Symptoms   { get; set; }
        public DateTime Duration { get; set; }
        public string Intensity { get; set; }
    }
}
