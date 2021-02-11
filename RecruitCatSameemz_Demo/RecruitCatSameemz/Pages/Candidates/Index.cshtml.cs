using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSameemz.Data;
using RecruitCatSameemz.Pages.Models;

namespace RecruitCatSameemz.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSameemz.Data.RecruitCatSameemzContext _context;

        public IndexModel(RecruitCatSameemz.Data.RecruitCatSameemzContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate.ToListAsync();
        }
    }
}
