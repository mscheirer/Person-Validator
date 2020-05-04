using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class IsCnpValid : ISpecification<Person>
    {
        public bool IsSatisfiedBy(Person entity)
        {
            return entity.Document.Length == 13 && long.TryParse(entity.Document, out long i);
        }
    }
}
