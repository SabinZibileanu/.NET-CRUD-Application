using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEndCST.Model;

namespace BackEndCST.Data
{
    public class AspNetUsersContext : DbContext
    {
        public AspNetUsersContext (DbContextOptions<AspNetUsersContext> options)
            : base(options)
        {
        }

        public DbSet<BackEndCST.Model.AspNetUsers> AspNetUsers { get; set; }
    }
}
