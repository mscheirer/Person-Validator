using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class _IsBornAtValidDate : ISpecification<Person>
    {
        public bool IsSatisfiedBy(Person entity)
        {
            return entity.BornAt != DateTime.MinValue;
        }
    }
}
