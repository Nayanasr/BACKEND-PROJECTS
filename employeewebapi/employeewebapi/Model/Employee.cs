using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeewebapi.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
    }
}
