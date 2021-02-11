using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSameemz.Data;
using RecruitCatSameemz.Pages.Models;

namespace RecruitCatSameemz.Pages.Addresses
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatSameemz.Data.RecruitCatSameemzContext _context;

        public DeleteModel(RecruitCatSameemz.Data.RecruitCatSameemzContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Address Address { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Address = await _context.Address.FirstOrDefaultAsync(m => m.AddressId == id);

            if (Address == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Address = await _context.Address.FindAsync(id);

            if (Address != null)
            {
                _context.Address.Remove(Address);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
