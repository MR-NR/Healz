using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Heals_Data
{
    public class Bill
    {
        public int Id { get; set; }

        public virtual Visit Visit { get; set; }

        public string MedicineTP { get; set; }
        public int CheckPrice { get; set; }
        public int TotalPrice { get; set; }
        public string Detail { get; set; }
        public string Method { get; set; }

    }
}
