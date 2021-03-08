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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly StoreContext _context;

        public EmployeeRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            await _context.employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _context.employees.ToListAsync();

        }
    }
}
