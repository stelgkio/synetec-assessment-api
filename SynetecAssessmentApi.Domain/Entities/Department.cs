using SynetecAssessmentApi.Domain.Enums;
using SynetecAssessmentApi.Domain.Shared;
using System.Collections.Generic;

namespace SynetecAssessmentApi.Domain
{
    public class Department : BaseEntity
    {
        public DepartmentTitles Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public Department(
            int id,
            DepartmentTitles title,
            string description) : base(id)
        {
            Title = title;
            Description = description;
        }
    }
}
