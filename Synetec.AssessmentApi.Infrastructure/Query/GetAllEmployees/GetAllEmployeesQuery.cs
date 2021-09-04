using MediatR;
using SynetecAssessmentApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Infrastructure.Query
{
    public class GetAllEmployeesQuery :IRequest<List<Employee>>
    {
    }
}
