﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        DbSet<TestModel> testModels { get; set; }
        DbSet<ApplicationUser> applicationUsers{ get; set; }
       DbSet<UserFollow> userFollows { get; set; }
    }
}
