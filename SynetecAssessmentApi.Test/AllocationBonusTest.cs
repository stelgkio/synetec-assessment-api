using SynetecAssessmentApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SynetecAssessmentApi.Test
{
    public class AllocationBonusTest
    {
        [Fact]
        public void BonusAllocationTest()
        {
            var allocationm = new AllocationBonus();
            var result = allocationm.BonusAllocation(0.09M, 654789M);
            Assert.Equal(58931M, result);

        }
    }
}
