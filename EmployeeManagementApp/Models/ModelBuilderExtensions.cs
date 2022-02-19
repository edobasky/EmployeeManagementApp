using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Eddy",
                   Department = Dept.IT,
                   Email = "eddyzig@g.com"
               },
                new Employee
                {
                    Id = 2,
                    Name = "Kate",
                    Department = Dept.HR,
                    Email = "Kt@g.com"
                },
                 new Employee
                 {
                     Id = 3,
                     Name = "John",
                     Department = Dept.IT,
                     Email = "jd@g.com"
                 }
               );

        }
    }
}
