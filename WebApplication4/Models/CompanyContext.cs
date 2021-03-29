using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 101,
                Name= "Ramu"
            });
        }
        public DbSet<Employee> employees { get; set; }
    }
}
