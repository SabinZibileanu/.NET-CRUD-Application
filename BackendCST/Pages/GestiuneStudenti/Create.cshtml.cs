using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BackEndCST.Data;
using BackEndCST.Model;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
namespace BackEndCST.Pages.GestiuneStudenti
{
    [Authorize]
    public class CreateModel : PageModel
    {   
        private readonly BackEndCST.Data.StudentContext _context;

        public CreateModel(BackEndCST.Data.StudentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Students Students { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _context.Students.Add(Students);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            
            
        }
    }
}
