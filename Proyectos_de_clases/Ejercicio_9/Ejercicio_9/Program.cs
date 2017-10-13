using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//09. Escribir un programa que imprima por pantalla una pirámide como la siguiente:
//*************************
//El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo.
//Para el ejemplo anterior la altura ingresada fue de 5.

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            do
            {

                int altura, ancho = 0;
                Console.WriteLine("Ingrese la altura: ");
                int.TryParse(Console.ReadLine(), out altura);
                float espacios = (float)altura-1;
                while (altura > 0)
                {
                    Console.WriteLine("\n");
                    if (ancho != 0)
                        ancho += 2;
                    else
                        ancho = 1;
                    for (float i = espacios; i > 0; i--)
                        Console.Write(" ");
                    for (int i = ancho; i > 0; i--)
                        Console.Write("*");
                    altura--;
                    espacios--;
                }
                Console.ReadKey();
                Console.WriteLine("\nContinuar?");
                continuar=Console.ReadLine();
            } while (continuar!="n");
        }
    }
}
