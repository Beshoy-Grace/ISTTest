using ISTTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Infrastructure.Data
{
    public class StoreContext :DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
