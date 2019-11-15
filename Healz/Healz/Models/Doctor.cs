
using System;

namespace Healz.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Youtube { get; set; }
        public string Google { get; set; }
        public Specialization MySpecialization { get; set; }
        public  string Designation { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Degree { get; set; }
        public string University { get; set;}
        public DateTime UniStartDate { get; set; }
        public DateTime UniEndDate { get; set; }
        public Language MyLanguage { get; set; }


        
    }
    public enum Specialization
    {
        Heart,
        Bones,
        Nerve
    }
    public enum Language
    {
        English,
        Urdu,
        British,
        Arabic
    }
}