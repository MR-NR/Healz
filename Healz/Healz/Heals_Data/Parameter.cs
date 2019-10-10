using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Parameter
    {
        public int Id { get; set; }
        public virtual Test Test { get; set; }
        public string Name { get; set; }
        public string MinValue { get; set; }
        public string NormalValue { get; set; }
        public string MaxValue { get; set; }
    }
}
