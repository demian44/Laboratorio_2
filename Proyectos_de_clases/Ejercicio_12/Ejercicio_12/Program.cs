using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;


//12. Realizar un programa que sume números enteros hasta que el usuario lo determine, 
//por medio de un mensaje ―¿Continua? (S/N)‖.
//En el método estático ValidaS_N() de la clase ValidarRespuesta, se validará el ingreso
//de opciones.El método NO recibe parámetros y devuelve un valor de tipo booleano, TRUE
//si se ingreso una 'S' y FALSE si se ingreso una 'N'. El método deberá validar si otro
//caracter fue ingresado mostrando un mensaje de error y pidiendo el reingreso del mismo.

namespace Ejercicio_12.IngresarNumeros
{
    class Program
    {
        static string respuesta;
        static void Main(string[] args)
        {
            int numero = 0, acumulador = 0;
            do
            {
                if (!CargarNumero("Ingrese un numero: ", "Error, ingrese solo numeros.", 3, ref numero))
                    break;
                Console.WriteLine();
                int.TryParse(Console.ReadLine(), out numero);
                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();
                acumulador += numero;
            } while (ValidarS_N());
            Console.Clear();
            Console.WriteLine("Suma total: " + acumulador);
        }
        public static bool ValidarS_N()
        {
            if (respuesta.ToLower() != "n") return true;
            return false;
        }
        public static bool CargarNumero(string mensaje, string msjError, int intentos, ref int numero)
        {
            bool retorno = false;
            while (intentos > 0)
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    retorno = true;
                    break;
                }
                Console.WriteLine(msjError);
                Console.WriteLine(mensaje);
                intentos--;
            }
            return retorno;
        }
    }


}
