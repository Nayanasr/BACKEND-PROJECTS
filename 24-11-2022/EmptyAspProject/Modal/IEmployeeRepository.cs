using System.Collections.Generic;

namespace EmptyAspProject.Modal {
    public interface IEmployeeRepository {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();

        Employee create(Employee employee);
    }
}
