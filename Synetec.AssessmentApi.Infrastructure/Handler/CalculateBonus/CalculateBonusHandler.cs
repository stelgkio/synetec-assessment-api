using MediatR;
using SynetecAssessmentApi.Infrastructure.Command;
using SynetecAssessmentApi.Infrastructure.Dtos;
using SynetecAssessmentApi.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Infrastructure.Handler.CalculateBonusHandler
{
    public class CalculateBonusHandler : IRequestHandler<CalculateBonusCommand, BonusPoolCalculatorResultDto>
    {
        private readonly IBonusPoolServices _bonusPoolServices;
        public CalculateBonusHandler(IBonusPoolServices bonusPoolServices)
        {
            _bonusPoolServices = bonusPoolServices;
        }
        public async Task<BonusPoolCalculatorResultDto> Handle(CalculateBonusCommand request, CancellationToken cancellationToken)
        {
            return await _bonusPoolServices.PoolCalculatorResult(request.TotalBonusPoolAmount, request.SelectedEmployeeId);
        }
    }
}
