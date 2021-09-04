using FluentValidation;
using MediatR;
using SynetecAssessmentApi.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Infrastructure.Command
{
    public class CalculateBonusCommand : IRequest<BonusPoolCalculatorResultDto>
    {
        public int TotalBonusPoolAmount { get; set; }
        public int SelectedEmployeeId { get; set; }
        public CalculateBonusCommand(int TotalBonusPoolAmount, int SelectedEmployeeId)
        {
            this.TotalBonusPoolAmount = TotalBonusPoolAmount;
            this.SelectedEmployeeId = SelectedEmployeeId;
        }
    }

    public class CalculateBonusCommandValidator : AbstractValidator<CalculateBonusCommand>
    {
        public CalculateBonusCommandValidator()
        {
            RuleFor(x => x.SelectedEmployeeId)
                .NotEmpty().WithMessage("Value can not be EMPTY")
                .NotNull().WithMessage("Value can not be NULL")
                .GreaterThan(0)
                .WithMessage("Value can not be ZERO");
            RuleFor(x => x.TotalBonusPoolAmount).NotEmpty()
                .NotEmpty().WithMessage("Value can not be EMPTY")
                .NotNull().WithMessage("Value can not be NULL")
                .GreaterThan(0)
                .WithMessage("Value can not be ZERO");
        }
    }
}
