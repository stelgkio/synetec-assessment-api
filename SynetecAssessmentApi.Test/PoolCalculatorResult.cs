using Microsoft.EntityFrameworkCore;
using SynetecAssessmentApi.Infrastructure.Dtos;
using SynetecAssessmentApi.Infrastructure.Services;
using SynetecAssessmentApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SynetecAssessmentApi.Test
{
    public class PoolCalculatorResult : BaseTestClass
    {
        [Fact]
        public async void PoolCalculte()
        {
            var dbContextOptionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            dbContextOptionBuilder.UseInMemoryDatabase(databaseName: "HrDb1");

            var dbContext = new AppDbContext(dbContextOptionBuilder.Options);

            DbSetTest(dbContext);

            var employeeservice = new BonusPoolService(dbContext);
            var result = await employeeservice.PoolCalculatorResult(123123,1);

            Assert.IsType<BonusPoolCalculatorResultDto>(result);
            Assert.NotNull(result);

        }
    }
   
}
