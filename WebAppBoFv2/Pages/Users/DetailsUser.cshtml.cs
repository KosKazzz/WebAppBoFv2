using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppBoFv2.Data;
using WebAppBoFv2.Models;

namespace WebAppBoFv2
{
    [Authorize(Roles = "admin")]
    public class DetailsUserModel : PageModel
    {
        private readonly WebAppBoFv2.Data.WebAppBoFv2Context _context;

        public DetailsUserModel(WebAppBoFv2.Data.WebAppBoFv2Context context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
