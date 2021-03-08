using ISTTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Interfaces
{
   public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllDepartmentAsync();
        Task<Department> AddDepartmentAsync(Department department);

    }
}
