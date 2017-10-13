using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Validacion
    {
        //Valida que una variable de tipo int se encuentre entre un rango determinado.
        //@int min - valor mínimo del rango
        //@int max - valor máximo del rango
        //@int valor - valor entero a evaluar
        public static bool ValidarRangoNumerico(int min, int max, int valor)
        {
            if (valor >= min && valor <= max) return true;
            return false;
        }
    }
   
}
