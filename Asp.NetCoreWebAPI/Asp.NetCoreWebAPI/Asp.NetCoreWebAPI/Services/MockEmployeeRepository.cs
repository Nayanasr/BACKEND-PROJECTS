using Asp.NetCoreWebAPI.Models;
using Asp.NetCoreWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreWebAPI.Services
{
    public class MockEmployeeRepository : IEmployeeRepository 
    {
        public List<Employee> _employee = new List<Employee>();
        public MockEmployeeRepository() {
            _employee.Add(new Employee() { Id = 1, Name = "Nayana", Phone = 1234784, Place = "Bangalore" });
            _employee.Add(new Employee() { Id = 2, Name = "Jayanth", Phone = 34569876, Place = "Tumkur" });
            _employee.Add(new Employee() { Id = 3, Name = "Rahul", Phone = 8765098, Place = "mangalore" });
            _employee.Add(new Employee() { Id = 4, Name = "Abhi", Phone = 5647924, Place = "Mysore" });

        }

        public Employee Add(Employee employee) {
            employee.Id = _employee.Max(e => e.Id) + 1;
            _employee.Add(employee);
            return employee;
        }

        public Employee Delete(int id) {
            Employee employee = _employee.FirstOrDefault(e => e.Id == id);
            if (employee != null) {
                _employee.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee() {
            return _employee;
        }

        public Employee GetEmployee(int id) {
            return _employee.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employeeUpdated) {
            Employee employee = _employee.FirstOrDefault(e => e.Id == employeeUpdated.Id);
            if (employee != null) {
                employee.Name = employeeUpdated.Name;
                employee.Phone = employeeUpdated.Phone;
                employee.Place = employeeUpdated.Place;
            }
            return employee;
        }
    }
}
