using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class PatientLaboratoryTest
    {
        public int Id { get; set; }
        public virtual Visit Visit { get; set; }
        public RepotDetails RepotDetails { get; set; }
        public string DoctorRemarks { get; set; }
        public DateTime TimeDate { get; set; }
        public string Lab { get; set; }

    }
}
