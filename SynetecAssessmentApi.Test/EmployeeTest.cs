
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Moq;
using SynetecAssessmentApi.Controllers;
using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Infrastructure.Interfaces;
using SynetecAssessmentApi.Persistence;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using SynetecAssessmentApi.Infrastructure.Services;
using SynetecAssessmentApi.Domain.Enums;

namespace SynetecAssessmentApi.Test
{
    public class EmployeeTest :BaseTestClass
    {
        [Fact]
        public async void GetAllEmployees()
        {
            var dbContextOptionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            dbContextOptionBuilder.UseInMemoryDatabase(databaseName: "HrDb1");

            var dbContext = new AppDbContext(dbContextOptionBuilder.Options);
             
            DbSetTest(dbContext);

           var employeeservice = new EmployeeService(dbContext);
            var result = await employeeservice.GetAllEmployees();

            Assert.IsType<List<Employee>>(result);
            Assert.NotNull(result);
          

        }

    }
}
