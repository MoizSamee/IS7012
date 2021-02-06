using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Title { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public decimal? PreviousSalary { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int? Grade { get; set; }
        public int CandidateId { get; set; }

    }
}
