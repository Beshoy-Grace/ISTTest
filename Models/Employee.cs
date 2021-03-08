using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int departmentId { get; set; }
        public Department department { get; set; }
    }
}
