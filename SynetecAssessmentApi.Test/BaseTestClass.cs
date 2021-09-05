﻿using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Domain.Enums;
using SynetecAssessmentApi.Persistence;
using System.Collections.Generic;

namespace SynetecAssessmentApi.Test
{
    public class BaseTestClass
    {
        public  void DbSetTest(AppDbContext context)
        {
            // Setting up Test DB Data
            var initialDepartmentEntities = new List<Department>
            {
                new Department(1, DepartmentTitles.Finance, "The finance department for the company"),
                new Department(2, DepartmentTitles.Human_Resources, "The Human Resources department for the company"),
                new Department(3, DepartmentTitles.IT, "The IT support department for the company"),
                new Department(4, DepartmentTitles.Marketing, "The Marketing department for the company")
            };

            var initialEmployeeEntities = new List<Employee>
            {
                new Employee(1, "John Smith", "Accountant (Senior)", 60000, 1),
                new Employee(2, "Janet Jones", "HR Director", 90000, 2),
                new Employee(3, "Robert Rinser", "IT Director", 95000, 3),
                new Employee(4, "Jilly Thornton", "Marketing Manager (Senior)", 55000, 4),
                new Employee(5, "Gemma Jones", "Marketing Manager (Junior)", 45000, 4),
                new Employee(6, "Peter Bateman", "IT Support Engineer", 35000, 3),
                new Employee(7, "Azimir Smirkov", "Creative Director", 62500, 4),
                new Employee(8, "Penelope Scunthorpe", "Creative Assistant", 38750, 4),
                new Employee(9, "Amil Kahn", "IT Support Engineer", 36000, 3),
                new Employee(10, "Joe Masters", "IT Support Engineer", 36500, 3),
                new Employee(11, "Paul Azgul", "HR Manager", 53000, 2),
                new Employee(12, "Jennifer Smith", "Accountant (Junior)", 48000, 1),
            };

            context.Departments.AddRange(initialDepartmentEntities);
            context.Employees.AddRange(initialEmployeeEntities);

            context.SaveChanges();
        }
    }
}