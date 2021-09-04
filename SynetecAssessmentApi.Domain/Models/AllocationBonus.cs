using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecAssessmentApi.Domain.Models
{
    public class AllocationBonus
    {
        public decimal BonusAllocation(decimal bonusPercentage, decimal totalSalary)
        {
            var x =(bonusPercentage * totalSalary);
            return x;
        }

    }
}
