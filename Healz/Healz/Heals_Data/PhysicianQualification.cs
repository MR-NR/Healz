using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class PhysicianQualification
    {
        public int Id { get; set; }

        public string QualificationName { get; set; }
        public string InstituteName { get; set; }
        public DateTime ProcurementYear { get; set; }
        public string Country { get; set; }

        public virtual Specialization Specialization { get; set; }
    }
}
