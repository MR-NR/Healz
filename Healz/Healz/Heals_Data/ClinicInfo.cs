using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class ClinicInfo
    {
        //public ClinicInfo()
        //{
        //   this.Physicians = new HashSet<Physician>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public virtual List<Physicin_ClinicInfo> Physicin_ClinicInfos { get; set; }

        //public int PhysicianId { get; set; }

    }
}
