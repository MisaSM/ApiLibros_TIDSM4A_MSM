using Microsoft.EntityFrameworkCore;
using P2_MSM_TIDSM4A_U3.Data.Models;

namespace P2_MSM_TIDSM4A_U3.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        
        
        }

        public DbSet<Book> Books { get; set; }

    }
}
