using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEndCST.Model
{
    public class AutentificareDB : IdentityDbContext
    {
        public AutentificareDB(DbContextOptions<AutentificareDB> optiuni): base(optiuni)
        {

        }
    }
}
