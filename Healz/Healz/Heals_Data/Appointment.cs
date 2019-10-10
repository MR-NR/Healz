using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time{ get; set; }
        public string VisitStatus { get; set; }



        public virtual PatientInfo PatientInfo { get; set; }
        public virtual Physician Physician { get; set; }

    }


}

