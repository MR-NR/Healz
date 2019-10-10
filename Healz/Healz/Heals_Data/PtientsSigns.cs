using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class PtientsSigns
    {
        public int Id { get; set; }
        public virtual Signs Signs { get; set; }
        public virtual SignsValues  SignsValues{ get; set; }
    }
}
