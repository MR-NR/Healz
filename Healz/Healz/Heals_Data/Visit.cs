using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public DateTime Time { get; set; }
        public virtual Appointment Appointment{ get; set; }

    }
}
