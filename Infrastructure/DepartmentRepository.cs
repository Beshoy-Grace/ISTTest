using ISTTest.Infrastructure.Data;
using ISTTest.Interfaces;
using ISTTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Infrastructure
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly StoreContext _context;

        public DepartmentRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Department> AddDepartmentAsync(Department department)
        {
            await _context.departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<List<Department>> GetAllDepartmentAsync()
        {
            return await _context.departments.Include(x => x.employees).ToListAsync();
        }
    }
}
