using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApp.Models;

namespace EmployeeApp.Data
{
    public class EmployeeAppContext : DbContext
    {
        public EmployeeAppContext (DbContextOptions<EmployeeAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeApp.Models.Employee> Employee { get; set; }
    }
}
