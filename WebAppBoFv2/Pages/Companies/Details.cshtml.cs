using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppBoFv2.Data;
using WebAppBoFv2.Models;

namespace WebAppBoFv2
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppBoFv2.Data.WebAppBoFv2Context _context;

        public DetailsModel(WebAppBoFv2.Data.WebAppBoFv2Context context)
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

            Company = await _context.Company.FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
