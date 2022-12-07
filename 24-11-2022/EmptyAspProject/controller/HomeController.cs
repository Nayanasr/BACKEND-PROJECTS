using EmptyAspProject.Modal;
using EmptyAspProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyAspProject.controller {
    //add mvc but where as in add mvc core u can use only core methods 
    public class HomeController : Controller {
        //action metrhod which returns a string
        //constructor dependency injuction
        public IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        public ViewResult GetAllEmployee() {
            var data = _employeeRepository.GetAllEmployees();
            return View(data);
        }
        //viewData
        //public ViewResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //    ViewData["Employee"] = modal;
        //    ViewData["Title"] = "Details of Employee";
        //    return View(); // action method name as parameter
        //}

        //view bag is a wrapper around view Data
        //creates a loosely typed view
        //viewdata uses string keys to store and retrive the data
        //viewbag will dynamically resolves in the runtime
        //no-compail time type checking and intellisense

        //The view which binds to a specific type of ViewModel is strongly typed view
        //public ViewResult Details() {

        //}

        [Route("Home/EnvTests")]
        public ViewResult EnvTests() {
            return View();
        }

        [HttpGet]
        public IActionResult createPage() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) {
            Employee newEmployee = _employeeRepository.create(employee);
            return RedirectToAction("test", new { id = newEmployee.id });
        }

        public ViewResult Test() {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel();
            homeDetailsViewModel.employeeList= _employeeRepository.GetAllEmployees();
            homeDetailsViewModel.Title = "hello i am from hello";
            homeDetailsViewModel.employee = _employeeRepository.GetEmployee(5);
            return View(homeDetailsViewModel);
        }

        //public ViewResult Details() {
        //    //HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
        //    //     employeeList = _employeeRepository.GetAllEmployees(),
        //    //     Title =    "all employee list"
        //    //};
        //    var modal = _employeeRepository.GetAllEmployees();
        //    ViewBag.Employee = modal;
        //    ViewBag.Title = "Details of Employee";
        //    return View(modal); // action method name as parameter
        //}

        //The view which binds to a specific type of ViewModel

        //passing the view(html page name) directly  witnout mentioning the extention
        //Relative Path (no need of file extentions)
        //absulate path (where the file is in the different folder) we need to mention the file extention
        [Route("")]
        [Route("Home")]
        public IActionResult Index() {
            return View("MyViews/Test.cshtml");
        }

        [Route("Home/employee/{id?}")]
        public IActionResult employee(int? id) {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                employee = _employeeRepository.GetEmployee(id??1),
                Title = "Details of Employee"

            };

            return View(homeDetailsViewModel);

           
        }

       
    }
}