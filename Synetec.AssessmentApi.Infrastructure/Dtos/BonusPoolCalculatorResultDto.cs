using SynetecAssessmentApi.Domain;

namespace SynetecAssessmentApi.Infrastructure.Dtos
{
    public class BonusPoolCalculatorResultDto
    {
        public decimal Amount { get; set; }
        public Employee Employee { get; set; }
    }
}
