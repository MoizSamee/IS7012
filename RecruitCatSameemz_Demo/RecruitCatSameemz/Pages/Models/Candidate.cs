using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSameemz.Pages.Models
{
    public class Candidate
    {
        [Display(Name = "Candidate ID")]
        public int CandidateId { get; set; }

        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "First is Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Last is Required")]
        public string LastName { get; set; }

        [Display(Name = "Target Salary")]
        [DataType(DataType.Currency)]
        [Range(0, 9999999)]
        public int? TargetSalary { get; set; }

        [Display(Name = "Expected Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Job Title")]
        public JobTitle JobTitle { get; set; }

        [Display(Name = "Industry")]
        public Industry Industry { get; set; }

        [Display(Name = "Company Name")]

        public Company Company { get; set; }

        [Display(Name = "Company Id")]

        public int CompanyId { get; set; }

        [Display(Name = "Job Title Id")]
        public int JobTitleId { get; set; }

        [Display(Name = "Industry Id")]
        public int IndustryId { get; set; }

        [Display(Name = "Current Employer")]
        public String CurrentEmployer { get; set; }

        [Display(Name = "Address")]
        [StringLength(100, MinimumLength = 3)]
        public string Address { get; set; }

        [Display(Name = "Phone No")]
        [Phone]
        [Required]
        public string PhoneNo { get; set; }

        [Display(Name = "Gender")]
        [StringLength(6, MinimumLength = 4)]
        public string Gender { get; set; }

        [Display(Name = "Work Ex in Years")]
        [Range(0,100)]
        public decimal? ExpInYears { get; set; }

        [Display(Name = "SSN")]
        [Required(ErrorMessage = "SSN is Required")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        public string SSN { get; set; }

        [Display(Name = "Email Address")]
        /*[StringLength(25)]*/
        [EmailAddress]
        public string Email { get; set; }
    }
}
