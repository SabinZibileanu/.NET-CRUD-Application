using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEndCST.Model;

namespace BackEndCST.Data
{
    public class StudentsContext : DbContext
    {
        public StudentsContext (DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<BackEndCST.Model.Students> Students { get; set; }
    }
}
