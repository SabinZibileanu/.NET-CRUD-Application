using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BackEndCST.Data;
using BackEndCST.Model;
using Microsoft.AspNetCore.Authorization;

namespace BackEndCST.Pages.GestiuneUseri
{   [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly BackEndCST.Data.AspNetUsersContext _context;

        public DetailsModel(BackEndCST.Data.AspNetUsersContext context)
        {
            _context = context;
        }

        public AspNetUsers AspNetUsers { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AspNetUsers = await _context.AspNetUsers.FirstOrDefaultAsync(m => m.Id == id);

            if (AspNetUsers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
