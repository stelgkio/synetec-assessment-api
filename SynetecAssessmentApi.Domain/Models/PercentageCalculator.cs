namespace SynetecAssessmentApi.Domain
{
    public class PercentageCalculator
    {
        public decimal Persentage(decimal Salary, decimal TotalSalary)
        {
            return decimal.Round( Salary / TotalSalary,2);
        }

    }
}