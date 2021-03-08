using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Employee> employees { get; set; }
    }
}
