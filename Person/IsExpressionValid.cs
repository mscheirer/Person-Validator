using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Person
{
    public class IsExpressionValid<TEntity> : ISpecification<TEntity>
    {
        private readonly Expression<Func<TEntity, bool>> _expression;

        public IsExpressionValid(Expression<Func<TEntity, bool>> expression)
        {
            _expression = expression;
        }

        public bool IsSatisfiedBy(TEntity entity) => _expression.Compile()(entity);
    }
}
