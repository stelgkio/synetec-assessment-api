﻿using Microsoft.EntityFrameworkCore;
using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Domain.Models;
using SynetecAssessmentApi.Infrastructure.Dtos;
using SynetecAssessmentApi.Infrastructure.Interfaces;
using SynetecAssessmentApi.Persistence;
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
            var employee =  await _dbContext.Employees
                            .Include(x=> x.Department)              
                            .FirstOrDefaultAsync(item => item.Id == selectedEmployeeId);

            int totalSalary = (int)_dbContext.Employees.Sum(item => item.Salary);
            var percen = new PercentageCalculator();
            decimal bonusPercentage = percen.Persentage(employee.Salary, totalSalary);
            var allocation = new AllocationBonus();
            var bonusAllocation = allocation.BonusAllocation(bonusPercentage, totalSalary);

            return (new BonusPoolCalculatorResultDto { Amount = bonusAllocation, Employee = employee });

        }
      
    }
}
