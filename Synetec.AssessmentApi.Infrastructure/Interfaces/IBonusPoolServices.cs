using SynetecAssessmentApi.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Infrastructure.Interfaces
{
    public interface IBonusPoolServices
    {
        Task<BonusPoolCalculatorResultDto> PoolCalculatorResult(int bonusPoolAmount, int selectedEmployeeId);
    }
}
