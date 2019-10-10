using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class PastHistory
    {
        public int Id { get; set; }
        public string Dieses { get; set; }
        public DateTime Age { get; set; }
        public DateTime Duration { get; set; }
        public string Medication { get; set; }

    }
}
