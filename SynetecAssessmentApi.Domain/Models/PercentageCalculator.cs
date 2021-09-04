namespace SynetecAssessmentApi.Domain
{
    public class PercentageCalculator
    {
        public decimal Persentage(decimal Salary, decimal TotalSalary)
        {
            return Salary / TotalSalary;
        }

    }
}