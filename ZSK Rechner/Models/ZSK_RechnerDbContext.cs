using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ZSK_Rechner.Models
{
    public class ZSK_RechnerDbContext : DbContext
    {
        public ZSK_RechnerDbContext(DbContextOptions<ZSK_RechnerDbContext> options)
            : base(options)
        {    
        }

        public DbSet<Tiere> Tiere { get; set; }
    }
}
