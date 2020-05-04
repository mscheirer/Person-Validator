using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class _IsPersonInAdulthood : ISpecification<Person>
    {
        public bool IsSatisfiedBy(Person entity)
        {
            return entity.Age > 17;
        }
    }
}
