using ISTTest.Interfaces;
using ISTTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployee()
        {
            return await _employeeRepository.GetAllEmployeeAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> AddEmployee( Employee employee)
        {
            return await _employeeRepository.AddEmployeeAsync(employee);
        }
    }
}
