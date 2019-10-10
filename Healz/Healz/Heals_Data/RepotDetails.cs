using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class RepotDetails
    {
        public int Id { get; set; }
        public virtual Test Test { get; set; }
        public string PrameterName{ get; set; }
        public string Result { get; set; }

    }
}
