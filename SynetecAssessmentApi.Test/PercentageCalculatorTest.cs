using SynetecAssessmentApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SynetecAssessmentApi.Test
{
    public class PercentageCalculatorTest
    {
        [Fact]
        public void BonusAllocationTest()
        {
            var allocationm = new PercentageCalculator();
            var result = allocationm.Persentage(60000,654987);
            Assert.Equal(0.09M, result);
        }
    }
}
