using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSameemz.Data;
using RecruitCatSameemz.Pages.Models;

namespace RecruitCatSameemz.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSameemz.Data.RecruitCatSameemzContext _context;

        public DetailsModel(RecruitCatSameemz.Data.RecruitCatSameemzContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.Candidates)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
