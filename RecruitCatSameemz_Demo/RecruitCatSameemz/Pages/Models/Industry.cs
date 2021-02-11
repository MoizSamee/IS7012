using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    
    public class Industry
    {
        [Display(Name = "Industry ID")]
        [Range(1, 9999999)]
        public int IndustryId { get; set; }

        [Display(Name = "Company Name")]
        public string IndustryName { get; set; }

        [Display(Name = "Candidates")]
        public List<Candidate> Candidates { get; set; }

        [Display(Name = "Companies")]
        public List<Company> Companies { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }
        

    }

}
