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
    }
}
