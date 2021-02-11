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
        [Range(1,9999999)]
        public int CandidateId { get; set; }
        
        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Target Salary")]
        [DataType(DataType.Currency)]
        [Range(0, 9999999)]
        public int? TargetSalary { get; set; }

        [Display(Name = "Expected Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Current Job Title")]
        public JobTitle JobTitle { get; set; }
        //public Industry Industry { get; set; }
        //public int JobTitleId { get; set; }
        //public int IndustryId { get; set; }

        [Display(Name = "Current Employer")]
        public String CurrentEmployer { get; set; }

        [Display(Name = "Address")]
        public String Address { get; set; }

        [Display(Name = "Phone No")]
        [Phone]
        [Required]
        public string PhoneNo { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }
        
        [Display(Name = "Work Ex in Years")]
        public decimal? ExpInYears { get; set; }

        [Display(Name = "SSN")]
        [Required(ErrorMessage = "SSN is Required")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        public string SSN { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
