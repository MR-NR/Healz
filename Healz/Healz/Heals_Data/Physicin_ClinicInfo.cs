using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Physicin_ClinicInfo
    {

       
        public int PhysicianId { get; set; }
        public Physician Physician { get; set; }



        
        public int ClinicInfoId { get; set; }
       
        public ClinicInfo ClinicInfo { get; set; }
    }
}
