using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class ParameterValue
    {
        public int Id { get; set; }
        public virtual Parameter Parameter { get; set; }
        public string Values { get; set; }
    }
}
