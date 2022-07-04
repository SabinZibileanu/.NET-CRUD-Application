using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BackEndCST.Data;
using BackEndCST.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;


namespace BackEndCST.Pages.GestiuneUseri
{   [Authorize]
    public class IndexModel : PageModel
    {
        private readonly BackEndCST.Data.AspNetUsersContext _context;
        private readonly IConfiguration Configuration;

        public IndexModel(BackEndCST.Data.AspNetUsersContext context, IConfiguration configuration)

        {
            _context = context;
            Configuration = configuration;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }

        public string CurrentSort { get; set; }

        public Pagination<AspNetUsers> AspNetUsers { get; set; }
        //public IList<AspNetUsers> AspNetUsers { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter, int? pageIndex)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CurrentSort = sortOrder;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<AspNetUsers> useri = from users in _context.AspNetUsers
                                            select users;

            if (!String.IsNullOrEmpty(searchString))
            {
                useri = useri.Where(users => users.UserName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    useri = useri.OrderByDescending(users => users.UserName);
                    break;

                default:
                    useri.OrderBy(users => users.UserName);
                    break;
            }
            var pageSize = Configuration.GetValue("PageSize", 4);
            AspNetUsers = await Pagination<AspNetUsers>.CreateAsync(
                useri.AsNoTracking(), pageIndex ?? 1, pageSize);
            //AspNetUsers = await useri.AsNoTracking().ToListAsync();
        }
    }
}
