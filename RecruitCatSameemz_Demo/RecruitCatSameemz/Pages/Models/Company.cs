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
        public int CompanyId { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "Company Name is Required")]
        public string ComapyName { get; set; }

        [Display(Name = "Job Title")]
        //[Required(ErrorMessage = "Job Title Name is Required")]
        public JobTitle JobTitle { get; set; }

        [Display(Name = "Job Title ID")]
        public int JobTitleId { get; set; }

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
        [StringLength(50)]
        public string Location { get; set; }

        [Display(Name = "Candidates Applied")]
        public List<Candidate> Candidates { get; set; }

        [Display(Name = "Industry")]
        //[Required(ErrorMessage = "Industry Name is Required")]
        public Industry Industry { get; set; }

        [Display(Name = "Industry ID")]
        public int IndustryId { get; set; }
        //public List<Address> CompanyAddresses { get; set; }
        //public int AddressId { get; set; }

        [Display(Name = "Company Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Display(Name = "Website")]
        [Url]
        public string WebsiteUrl { get; set; }

        [Display(Name = "Company Address")]
        [StringLength(250)]
        public string Address;

    }
}
