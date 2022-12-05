using System;
using Microsoft.EntityFrameworkCore;
using TechJobsAuthentication.Models;

namespace TechJobsAuthentication.Data
{
    public class JobDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasKey(et => new { et.Id });

            base.OnModelCreating(modelBuilder);
        }
}
