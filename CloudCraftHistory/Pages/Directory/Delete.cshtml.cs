using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CloudCraftHistory.Data;
using CloudCraftHistory.Models;

namespace CloudCraftHistory.Pages.Directory
{
    public class DeleteModel : PageModel
    {
        private readonly CloudCraftHistory.Data.CloudCraftHistoryContext _context;

        public DeleteModel(CloudCraftHistory.Data.CloudCraftHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);

            if (Member == null)
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

            Member = await _context.Member.FindAsync(id);

            if (Member != null)
            {
                _context.Member.Remove(Member);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
