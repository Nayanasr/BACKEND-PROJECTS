using EmptyAspProject.Modal;
using System.Collections.Generic;

namespace EmptyAspProject.ViewModels {
    public class HomeDetailsViewModel {
        public Employee employee { get; set; }
        public string Title { get; set; }
        public IEnumerable<Employee> employeeList { get; set; }
    }
}

