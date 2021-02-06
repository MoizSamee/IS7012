using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public JobTitle JobTitle { get; set; }
        public Industry Industry { get; set; }
        public int JobTitleId { get; set; }
        public int IndustryId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public string PhoneNo { get; set; }
        public bool? Gender { get; set; }
        public decimal? ExpInYears { get; set; }
        public string SSN { get; set; }
    }
}
