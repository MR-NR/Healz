using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Healz.Models
{
    public class DoctorProfileViewModel
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SubTitle { get; set; }
        public IFormFile ProfilePhoto { get; set; }
        public string facebooklink { get; set; }
        public string twitterlink { get; set; }
        public string linkedin { get; set; }
        public string googlepluslink { get; set; }
        public string rsslink { get; set; }
        public string youtubelink { get; set; }
        public string Specializations { get; set; }
        public string Designation { get; set; }
        public string CompanyName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime startingDateExperience { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime EndingDateExperience { get; set; }
        public string DegreeName { get; set; }
        public string InstituteName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime StartingDateStudy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime EndingDateStudy { get; set; }
        public string Languages { get; set; }
        public string AwardTitle { get; set; }
        public string AwardOccasion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime AwardDate { get; set; }
        public string MembershipTitle { get; set; }
        public string MembershipLocation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime MembershipDate { get; set; }
        public string RegistrationID { get; set; }
        public string RegistrationLocation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime RegistrationDate { get; set; }
        public string AcceptedInsurance { get; set; }
        public string VideoIntroduction { get; set; }

    }

}
