using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 14. Realizar una clase llamada ‗CalculoDeArea‘ que posea 3 métodos de clase (estáticos),
 *  double CalcularCuadrado(double), double CalcularTriangulo(double, double) y double CalcularCirculo(double),
 *  que realicen el cálculo del área que corresponda.
 *  El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */
namespace Ejercicio_13
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }
        public static double CalcularTriangulo(double baseT, double alturaT)
        {
            return (baseT * alturaT)/2;
        }
        public static double CalcularCirculo(double radio)
        {
            return Math.PI*radio*radio;
        }
    }
}
