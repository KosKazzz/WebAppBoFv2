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
    public class IndexUserModel : PageModel
    {
        private readonly WebAppBoFv2.Data.WebAppBoFv2Context _context;

        public IndexUserModel(WebAppBoFv2.Data.WebAppBoFv2Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
