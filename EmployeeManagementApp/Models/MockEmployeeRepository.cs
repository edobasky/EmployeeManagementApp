using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department ="HR" , Email="mary1@g.com"},
                 new Employee() {Id = 2, Name = "John", Department ="IT" , Email="john@g.com"},
                  new Employee() {Id = 3, Name = "Mark", Department ="HR" , Email="mary1@g.com"},
            };
        }

        public IEnumerable GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(em => em.Id == Id);
        }
    }
}
