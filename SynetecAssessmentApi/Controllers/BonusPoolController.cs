using MediatR;
using Microsoft.AspNetCore.Mvc;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Infrastructure.Command;
using System;
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

      
        [HttpPost()]
        public async Task<IActionResult> CalculateBonus([FromBody] CalculateBonusDto request)
        {
            try {
                var query = new CalculateBonusCommand(request.TotalBonusPoolAmount, request.SelectedEmployeeId);
                var result = await _mediator.Send(query);
                return result != null ? Ok(result) : NotFound();
            } catch (Exception ex) {

                return BadRequest(ex.Message);
            }
           
        }
    }
}
