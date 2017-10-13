using System;
using System.Threading;

namespace Clase_1_B
{
    class Program
    {
        static int cantidad_Num_Perfectos = 4;
        static void Main(string[] args)
        {
            int contador = 0;
            Console.Clear();
            Console.WriteLine("--------------------------------\nLista de numeros perfectos: ");
            Console.Clear();
            for (int numero = 1; ; numero++)
            {
                int acumulador = 0;
                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                        acumulador += j;
                }
                if (acumulador == numero)
                {
                    Thread.Sleep(400);
                    contador++;
                    Console.WriteLine("{0}. {1}", contador, numero);
                }
                if (contador == cantidad_Num_Perfectos)
                    break;
            }
            Thread.Sleep(400);
            Console.WriteLine("Todo bien piolin.");
            Console.ReadKey();
        }
    }
}
