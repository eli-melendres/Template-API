using Core.Domain.Validators;
using Core.Domain.Entities;
using Domain.Entities;
using Domain.Others.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    /// <summary>
    /// Clase que ejecuta las validaciones de negocio para una entidad de dominio,
    /// definiendo reglas en base a la libreria de FluentValidation
    /// </summary>
    public class DummyEntityValidator : EntityValidator<DummyEntity>
    {
        public DummyEntityValidator() 
        {
            RuleFor(x => x.DummyProperty).NotNull().NotEmpty().WitMessage(DomainConstants.DUMMY_CONSTANT);
        }
    }
}
