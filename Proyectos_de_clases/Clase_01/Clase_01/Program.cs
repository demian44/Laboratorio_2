using System;
/* 
 * 01. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo,
 * el valor mínimo y el promedio.
 * 02. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, 
 * caso contrario, mostrar el mensaje: "ERROR. Reingresar número!!!".
 * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 * 03. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 * 04. Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
 * (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación 
 * que encuentre los 4 primeros números perfectos. Nota: Utilizar
 */
namespace Clase_01
{
    class Program
    {
        public static int CANTIDAD = 5;
        static void Main(string[] args)
        {
            
            double[] arrayNumeros = new double[5];
            int index;
            double maximo=0, minimo=0, promedio=0, acumulador=0; // Si no la inicializo aparece un error en lista de errores.
            for (index = 0; index < CANTIDAD; index++)
            {
                Console.Clear();
                Console.WriteLine("Ingrse el {0} numero: ", index + 1);
                while (!double.TryParse(Console.ReadLine(), out arrayNumeros[index]) || arrayNumeros[index] < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Error, ingrese un numero mayor o igual a 0.\nIngrse el {0}º numero: ", index + 1);
                }
                Console.WriteLine("Cuadrado:" +  Math.Pow(arrayNumeros[index], 2).ToString());
                Console.WriteLine("Cubo:" + Math.Pow(arrayNumeros[index], 3).ToString());
                encontrarMaximo(ref arrayNumeros[index], ref maximo, ref index);
                encontrarMinimo(ref arrayNumeros[index], ref minimo, ref index);
                acumulador += arrayNumeros[index];
                mostarNumerosPrimosHasta((int)arrayNumeros[index]);
                Console.ReadKey();
            }
            Console.Clear();
            promedio = acumulador / index;
            Console.WriteLine("Minimo: {0}\nMaximo: {1}\nPromedio: {2}",minimo,maximo,promedio);
            Console.ReadKey();
        }
        static void encontrarMaximo(ref double numero,ref  double maximo,ref int index)
        {
            if ((index > 0 && maximo < numero) || index == 0)
                maximo = numero;
        }
        static void encontrarMinimo(ref double numero, ref double minimo, ref int index)
        {
            if ((index > 0 && minimo > numero) || index == 0)
                minimo = numero;
        }
        static void mostarNumerosPrimosHasta(int numero)
        {
            Boolean flag = true;
            for (int i = 1; i <= numero; i++)
            {                
                int contador = 0;
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        contador++;
                    if (contador > 1)
                        break;
                }
                if (contador == 1)
                {
                    if (flag)
                    {
                        Console.WriteLine("Numeros primos:");
                        Console.Write(i.ToString());
                        flag = false;
                    }
                    else
                        Console.Write(" - " + i.ToString());                 
                }
            }
        }
    }
}
