using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string ComapyName { get; set; }
        public string OpenPosition { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public List<Address> CompanyAddresses { get; set; }
        public int AddressId { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
