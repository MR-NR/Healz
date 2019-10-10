using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class PatientFamilyHistory
    {
        public int Id { get; set; }

        public virtual PatientInfo PatientInfo { get; set; }
        public string Relation { get; set; }
        public int Number { get; set; }
        public string Alive_Dead { get; set; }
        public DateTime DeathWithDate { get; set; }
        public string CauseOfDeath { get; set; }
        public string SufferingFrom { get; set; }

    }
}
