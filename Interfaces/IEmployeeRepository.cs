using ISTTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Interfaces
{
   public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeeAsync();
        Task<Employee> AddEmployeeAsync(Employee employee);
    }
}
