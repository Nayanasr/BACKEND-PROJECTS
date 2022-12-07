using ASP.NetEmpty3;
using ASP.NetEmpty3.Model;
using System.Collections.Generic;

namespace CrudOperationWebApi.Models
{
    public class SqlEmployeeReposatory : IEmployeeRepository
    {

        private readonly EmployeeDbContext context;
        public SqlEmployeeReposatory(EmployeeDbContext context) {
            this.context = context;
        }

        public Employee Add(Employee employee) {
            context.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Create(Employee employee) {
            throw new System.NotImplementedException();
        }

        public Employee Delete(int id) {
            Employee employee = context.employee.Find(id);
            if (employee != null) {
                context.employee.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee() {
            return context.employee;
        }

        public Employee GetEmployee(int id) {
            return context.employee.Find(id);
        }

        public IEnumerable<Employee> GetEmployeeDetails() {
            throw new System.NotImplementedException();
        }

        public Employee Update(Employee EmployeeDbContext) {
            var employee = context.employee.Attach(EmployeeDbContext);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return EmployeeDbContext;

        }
    }
}
