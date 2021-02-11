using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    public class Company
    {
        [Display(Name = "Company ID")]
        [Range(1, 9999999)]
        public int CompanyId { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string ComapyName { get; set; }

        [Display(Name = "Open Positions")]
        public List<JobTitle> OpenPositions { get; set; }

        [Display(Name = "Min Salary")]
        [DataType(DataType.Currency)]
        [Range(0, 9999999)]
        public int MinSalary { get; set; }


        [Display(Name = "Max Salary")]
        [Range(0, 9999999)]
        [DataType(DataType.Currency)]
        public int MaxSalary { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Candidates Applied")]
        public List<Candidate> Candidates { get; set; }

        [Display(Name = "Industry")]
        [Required]
        public Industry Industry { get; set; }

        [Display(Name = "Industry ID")]
        [Range(0, 9999999)]
        public int IndustryId { get; set; }
        //public List<Address> CompanyAddresses { get; set; }
        //public int AddressId { get; set; }
        
        public string Description { get; set; }

        [Display(Name = "Website")]
        [Url]
        public string WebsiteUrl { get; set; }

        [Display(Name = "Company Address")]
        public string Address;

    }
}
