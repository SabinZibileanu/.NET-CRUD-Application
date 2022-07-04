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

namespace BackEndCST.Pages.GestiuneStudenti
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly BackEndCST.Data.StudentContext _context;

        public DetailsModel(BackEndCST.Data.StudentContext context)
        {
            _context = context;
        }

        public Students Students { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Students = await _context.Students.FirstOrDefaultAsync(m => m.id_student == id);

            if (Students == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
