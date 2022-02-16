using EmployeeManagementApp.Models;
using EmployeeManagementApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employee;

        public HomeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public ViewResult Index()
        {
            var result = _employee.GetAllEmployees();
            return View(result);
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employee.GetEmployee(id?? 1),
                PageTitle = "Employee Details"
             };
            return View(homeDetailsViewModel);
        }
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                var newEmployee = _employee.AddEmployee(employee);
                return RedirectToAction("Details", new { id = newEmployee.Id });
            }

            return View();
        }
    }
}
