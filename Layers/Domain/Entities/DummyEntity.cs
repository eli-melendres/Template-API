using Core.Domain.Entities;
using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Clase que representa una entidad de dominio.
    /// Para poder implementar funcionalidad relacionada
    /// </summary>
    public class DummyEntity : DomainEntity<Guid,DummyEntityValidator>
    {
        // Toda propiedad de una entidad de dominio debe tener el setter privado
        public string DummyProperty { get; private set; }
        public DummyEntity()
        {
            Id = Guid.NewGuid();
        }
        //Una entidad de dominio debe tener al menos 1 contructor que le permita setear el valor de DummyProperty
        public DummyEntity(string dummyProperty)
        {
            DummyProperty = dummyProperty;
        }
        public void DummyMethod()
        { }
    }
}
