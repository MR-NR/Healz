using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool Action { get; set; }
    }
}
