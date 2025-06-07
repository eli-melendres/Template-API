using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Others.Utils
{
   
    /// <summary>
    ///  Clase que mantiene logica auxiliar (aislada) de la logica de negocio.
    ///  Puede contener funciones de todo tipo.
    /// </summary>
    public static class DummyUtils
    {
        //Metodo de la clase  
        // variable = DummyUtils.DummyMethod();
        public static void DummyMethod() 
        { 

        }
        // Metodo de extension - Se utiliza de manera global para el tipo de dato definido
        // variable_string.DummyExtensionMethod();
        public static void DummyExtensionMethod(this string arg)
        {

        }
    }
}
