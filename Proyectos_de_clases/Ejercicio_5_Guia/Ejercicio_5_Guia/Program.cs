using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 05. Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, 
 * cuyas sumas son iguales.
 * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas 
 * son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y 
 * (36 a 49) cuyas sumas son ambas iguales a 595.
 * 
 * !!!!!Se pide elaborar una aplicación que calcule los centros numéricos entre 1
 * y el número que el usuario ingrese por consola. Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).////
 *      
 */
namespace Ejercicio_5_Guia
{
    class Program
    {

        static void Main(string[] args)
        {
            UInt64 limite;
            int contador = 0;
            while (!UInt64.TryParse(Console.ReadLine(), out limite))
                Console.WriteLine("Valor incorrecto.");
            UInt64 j;
            for (UInt64 i = 1; i <= limite; i++)
            {
                UInt64 primerGrupo = 0, segundoGrupo = 0;
                for (j = 1; j < i; j++)
                    primerGrupo += j;
                j = i;
                while (primerGrupo > segundoGrupo)
                {
                    j++;
                    segundoGrupo += j;
                    if (primerGrupo == segundoGrupo)
                    {
                        contador++;
                        Console.WriteLine("Centro numerico {0}: {1}", contador, i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
