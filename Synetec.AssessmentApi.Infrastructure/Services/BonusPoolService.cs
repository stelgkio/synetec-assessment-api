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


                decimal bonusPercentage = Percetange(employee.Salary, totalSalary);
                decimal bonusAllocation = Allocation(bonusPercentage, bonusPoolAmount);



                return new BonusPoolCalculatorResultDto { Amount = bonusAllocation, Employee = employee };
            } catch (Exception ex) {

                throw new Exception(ex.Message);
            }
           

        }
        public decimal Percetange(decimal Salary, decimal TotalSalary)
        {
            var percentage = new PercentageCalculator();
            return  percentage.Persentage(Salary, TotalSalary);
        }

        public decimal Allocation(decimal bonusPercentage, decimal bonusPoolAmount)
        {
            var allocation = new AllocationBonus();
            return allocation.BonusAllocation(bonusPercentage, bonusPoolAmount);
        }




      
    }
}
