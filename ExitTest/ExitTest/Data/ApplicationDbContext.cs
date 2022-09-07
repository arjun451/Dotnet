using ExitTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ExitTest.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        DbSet<Follow> follows { get; set; } 
    }
}
