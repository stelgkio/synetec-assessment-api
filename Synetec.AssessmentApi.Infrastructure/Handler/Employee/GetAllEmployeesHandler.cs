using MediatR;
using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Infrastructure.Interfaces;
using SynetecAssessmentApi.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Infrastructure.Handler
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, List<Employee>>
    {
        private readonly IEmployeeService _employeeService;
        public GetAllEmployeesHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _employeeService.GetAllEmployees();
        }
    }
}
