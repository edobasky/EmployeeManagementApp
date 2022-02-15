using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int Id);
        public IEnumerable GetAllEmployees();
    }
}
