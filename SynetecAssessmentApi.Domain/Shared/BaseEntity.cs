using System;

namespace SynetecAssessmentApi.Domain.Shared
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}
