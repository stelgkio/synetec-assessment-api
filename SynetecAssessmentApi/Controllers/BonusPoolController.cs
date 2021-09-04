using MediatR;
using Microsoft.AspNetCore.Mvc;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Infrastructure.Command;
using SynetecAssessmentApi.Infrastructure.Query;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Controllers
{

    public class BonusPoolController : BaseController
    {
        private readonly IMediator _mediator;

        public BonusPoolController(IMediator mediator)
        {
            _mediator = mediator;              
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllEmployeesQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> CalculateBonus([FromBody] CalculateBonusDto request)
        {
            var query = new CalculateBonusCommand(request.TotalBonusPoolAmount, request.SelectedEmployeeId);
            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
