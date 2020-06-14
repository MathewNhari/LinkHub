using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShareLinkFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.Data
{
    public class ShareLinkDbContext :IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MATHEW\SQLEXPRESS;Database=EFShareLinkFinalDb;Trusted_Connection=True;");
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Url> Urls { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
