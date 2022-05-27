using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> Employee { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-VLTS583; Initial Catalog = TodoDb; Integrated Security = True");
        }
    }
}
