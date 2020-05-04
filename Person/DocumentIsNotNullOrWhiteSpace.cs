using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class DocumentIsNotNullOrWhiteSpace : ISpecification<Person>
    {
        public bool IsSatisfiedBy(Person entity)
        {
            return !string.IsNullOrWhiteSpace(entity.Document);
        }
    }
}
