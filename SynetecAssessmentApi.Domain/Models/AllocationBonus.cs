using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecAssessmentApi.Domain.Models
{
    public class AllocationBonus
    {
        public double BonusAllocation(decimal amount, decimal totalAmount)
        {
            return (double)(amount * totalAmount);
        }

    }
}
