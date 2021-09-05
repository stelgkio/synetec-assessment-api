using MediatR;
using Microsoft.AspNetCore.Mvc;
using SynetecAssessmentApi.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try {
                var query = new GetAllEmployeesQuery();
                var result = await _mediator.Send(query);

                return result != null ? Ok(result) : NotFound();
            } catch (Exception ex) {

                return BadRequest(ex.Message);
            }
        }
    }
}
