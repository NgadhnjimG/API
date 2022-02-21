using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.Entities;

namespace YFE_API.Configuration
{
    public class YfeDbContext : DbContext
    {
        public YfeDbContext(DbContextOptions<YfeDbContext> options) : base(options) { }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<BaseClass>()
           //.Property(b => b.IsDeleted)
           //.HasDefaultValue(false);

           // modelBuilder.Entity<BaseClass>()
           //.Property(b => b.IsActive)
           //.HasDefaultValue(true);

           // modelBuilder.Entity<BaseClass>()
           //.Property(b => b.CreatedAt)
           //.HasDefaultValue(DateTime.Now);
        }
    }
}
