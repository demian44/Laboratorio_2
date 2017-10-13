using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
 * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +,
 * -, * ó /). El usuario decidirá cuando finalizar el programa. Crear una clase llamada Calculadora que posea tres métodos 
 * estáticos (de clase): Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación
 * matemática. El método devolverá el resultado de la operación. Validar (Privado): Recibirá como parámetro el segundo 
 * número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISION. Este método devolverá TRUE si 
 * el número es distinto de CERO. Mostrar (público): Este método recibe como parámetro el resultado de la operación y lo 
 * muestra por pantalla.
 * No posee valor de retorno. 
 */
namespace Ejercicio_13
{
    class Calculadora
    {
        public static double Calcular(double valorA, double valorB, string operacion)
        {
            double resultado=0;
            switch (operacion)
            {
                case "+":
                    resultado = valorA + valorB;
                    break;
                case "-":
                    resultado = valorA - valorB;
                    break;
                case "*":
                    resultado = valorA * valorB;
                    break;
                case "/":
                    if (Validar(valorB))
                    {
                       resultado = valorA / valorB;
                    }
                    break;
            }
            return resultado;
        }
        public static void Mostrar(double resultado)
        {
            Console.WriteLine("Resultado: " + resultado);
        }
        public static bool ValidarOperadores(string operador)
        {
            bool retorno = true;
            if(operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                retorno = false;
            }
            return retorno;
        }
        private static bool Validar(double valorB)
        {
            bool retorno = false;
            if(valorB!=0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
