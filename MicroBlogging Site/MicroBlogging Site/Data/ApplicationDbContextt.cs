using MicroBlogging_Site.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MicroBlogging_Site.Data
{
    public class ApplicationDbContextt:IdentityDbContext
    {
        public ApplicationDbContextt(DbContextOptions<ApplicationDbContextt> options):base(options)
        {

        }
        DbSet<testmodel> Testmodels { get; set; }
    }
}
