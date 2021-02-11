using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    public class JobTitle
    {
        [Display(Name = "Job Title ID")]
        [Range(1, 9999999)]
        public int JobTitleId { get; set; }

        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Display(Name = "Minimum Salary")]
        [Range(0, 9999999)]
        public int MinSalary { get; set; }

        [Display(Name = "Max Salary")]
        [Range(1, 9999999)]
        public int MaxSalary { get; set; }
        //public decimal? PreviousSalary { get; set; }

        [Display(Name = "Candidates")]
        public List<Candidate> Candidates { get; set; }

        [Display(Name = "Grade")]
        public String Grade { get; set; }


        [Display(Name = "Full Time Status")]
        public bool fulltime { get; set; }

    }
}
