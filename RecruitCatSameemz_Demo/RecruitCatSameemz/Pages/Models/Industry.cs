using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    
    public class Industry
    {

        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
        public string Type { get; set; }
        public int CompaniesId { get; set; }
        public int CandidateId { get; set; }

    }

}
