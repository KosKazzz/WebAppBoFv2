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
    public class IndexModel : PageModel
    {
        private readonly WebAppBoFv2.Data.WebAppBoFv2Context _context;

        public IndexModel(WebAppBoFv2.Data.WebAppBoFv2Context context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        //public SelectList 
        //[BindProperty(SupportsGet = true)]
        //public string OrgInfo { get; set; }

        public async Task OnGetAsync()
        {
            //IQueryable<string> infoQuery = from m in _context.Company
            //                                orderby m.Info
            //                                select m.Info;
            var infos = from m in _context.Company
                         select m;
            if (!string.IsNullOrEmpty(SearchString)) {

                infos = infos.Where(s => s.Info.Contains(SearchString));
            }

            //Company = await _context.Company.ToListAsync();
            Company = await infos.ToListAsync();
        }
    }
}
