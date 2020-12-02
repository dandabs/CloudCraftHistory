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
    public class IndexModel : PageModel
    {
        private readonly CloudCraftHistory.Data.CloudCraftHistoryContext _context;

        public IndexModel(CloudCraftHistory.Data.CloudCraftHistoryContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}