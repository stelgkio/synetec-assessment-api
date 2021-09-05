using Microsoft.EntityFrameworkCore;
using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Domain.Models;
using SynetecAssessmentApi.Infrastructure.Dtos;
using SynetecAssessmentApi.Infrastructure.Interfaces;
using SynetecAssessmentApi.Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Infrastructure.Services
{
    public class BonusPoolService   : IBonusPoolServices
    {
        private readonly AppDbContext _dbContext;

        public BonusPoolService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<BonusPoolCalculatorResultDto> PoolCalculatorResult(int bonusPoolAmount, int selectedEmployeeId)
        {
            try {

                var employee = await _dbContext.Employees
                           .Include(x => x.Department)
                           .FirstOrDefaultAsync(item => item.Id == selectedEmployeeId);

                var totalSalary = await _dbContext.Employees.SumAsync(item => item.Salary);
                var percen = new PercentageCalculator();
                decimal bonusPercentage = percen.Persentage(employee.Salary, totalSalary);
                var allocation = new AllocationBonus();
                decimal bonusAllocation = allocation.BonusAllocation(bonusPercentage, bonusPoolAmount);

                return new BonusPoolCalculatorResultDto { Amount = bonusAllocation, Employee = employee };
            } catch (Exception ex) {

                throw new Exception(ex.Message);
            }
           

        }
      
    }
}
