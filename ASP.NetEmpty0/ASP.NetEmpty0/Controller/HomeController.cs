using ASP.NetEmpty3.Model;
using ASP.NetEmpty3.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreempty.controller
{
    [Route("Home")]
    public class HomeController : Controller {
        public IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        [Route("")]

        [Route("Index")]
        public string Index() {
            return _employeeRepository.GetEmployee(2).name;
        }

        [Route("Details")]
        public ViewResult Details() {
            HomeDetailsViewModel homeEmployeeDetails = new HomeDetailsViewModel() {
                //Employee modal=_employeeRepository.GetEmployee(2);
                //// ViewData["Employee"]=modal;
                //ViewData["Title"] = "Details Of Employee";
                //return View(modal);
                Employee = _employeeRepository.GetEmployee(2),
                Title = "Details of Employee"
            };

            return View(homeEmployeeDetails);
        }
    }


        //public ViewResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //}
       
        
        //public JsonResult Details() {
        //    Employee modal = _employeeRepository.GetEmployee(2);
        //    return Json(modal);
        //}

        //public IActionResult Index() {

        //    return View()
        // }
        //public IActionResult Employee() {

        //    return View();
        //}


    
}
