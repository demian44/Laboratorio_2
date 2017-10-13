using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 06. Escribir un programa que determine si un año es bisiesto.
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
 * salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no. 
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 *  
 * 
 */
namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String seguir="S";
            do
            {
                Console.Clear();
                int year;
                Console.WriteLine("Ingrese  un año");
                while (!int.TryParse(Console.ReadLine(), out year))
                    Console.WriteLine("Error.");
                if (year % 400 == 0 || ((year % 4 == 0) && (year % 100) != 0))
                    Console.WriteLine("El año es Biciesto.\n Volver a intentar ? y / n");
                else
                    Console.WriteLine("El año no es Biciesto.\n Volver a intentar? y/n");
                seguir = Console.ReadLine();
            } while (seguir.ToLower()!="n");
        }
    }
}
