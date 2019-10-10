using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Physician
    {
        //public Physician()
        //{
        //   this.ClinicInfos = new HashSet<ClinicInfo>();
        //}
        public int Id { get; set; }

        public string ProfessionlStatement { get; set; }
        public string PracticingFrom { get; set; }
        public string Contact { get; set; }
        public string PostalAddress { get; set; }
        public string CNIC { get; set; }
        public string MinitelStatus { get; set; }
        public string SpouseName { get; set; }

        public virtual List<Physicin_ClinicInfo> Physicin_ClinicInfos { get; set; }

      //  public int ClinicInfoId { get; set; }
        public virtual Registeration Registeration { get; set; }


    }
}
