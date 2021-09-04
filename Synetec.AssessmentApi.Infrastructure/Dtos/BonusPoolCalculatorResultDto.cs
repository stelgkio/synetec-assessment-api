using SynetecAssessmentApi.Domain;

namespace SynetecAssessmentApi.Infrastructure.Dtos
{
    public class BonusPoolCalculatorResultDto
    {
        public double Amount { get; set; }
        public Employee Employee { get; set; }
    }
}
