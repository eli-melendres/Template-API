using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public interface IValidate
    {
        bool IsValid { get; }
        IList<ValidationFailure> GetErrors();
    }
    public class DomainEntity<TKey,TValidator> : IValidate 
        where TValidator : IValidator, new()
    {
        public TKey Id { get; protected set; }
        public bool IsValid => ValidationResult.IsValid;
        public TValidator Validator { get; }
        public ValidationResult ValidationResult { get; set; }

        protected DomainEntity()
        {
            Validator = new TValidator();
        }

        protected void Validate() 
        { 
            var context = new ValidationContext<object>(this);
            ValidationResult = Validator.Validate(context);

        }

        public IList<ValidationFailure> GetErrors() 
        { 
            Validate();
            return ValidationResult.Errors();
        }
    }
}
