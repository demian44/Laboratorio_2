using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    static class Validacion
    {
        //Valida que una variable de tipo int se encuentre entre un rango determinado.
        //La variable debe ser menor o igual al maximo o mayor o igual al maximo
        public static bool Validar(int min, int max, int valor)
        {
            if (valor >= min && valor <= max) return true;
            return false;
        }
    }
}
