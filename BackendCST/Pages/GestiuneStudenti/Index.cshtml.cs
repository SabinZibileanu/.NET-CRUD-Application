using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BackEndCST.Data;
using Microsoft.AspNetCore.Authorization;
using BackEndCST.Model;

namespace BackEndCST.Pages.GestiuneStudenti
{   [Authorize]
    public class IndexModel : PageModel
    {
        private readonly BackEndCST.Data.StudentContext _context;

        public IndexModel(BackEndCST.Data.StudentContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
