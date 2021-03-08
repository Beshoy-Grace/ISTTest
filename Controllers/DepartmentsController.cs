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
    public class DepartmentsController : ControllerBase
    {

        private readonly IDepartmentRepository _DepartmentRepository;

        public DepartmentsController(IDepartmentRepository DepartmentRepository)
        {
            _DepartmentRepository = DepartmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetAllDepartment()
        {
            return await _DepartmentRepository.GetAllDepartmentAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Department>> AddDepartment(Department department)
        {
            return await _DepartmentRepository.AddDepartmentAsync(department);
        }
    }
}
