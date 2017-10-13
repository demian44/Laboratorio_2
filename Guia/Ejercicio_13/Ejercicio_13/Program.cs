using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerAlumnos;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //ControllerALumno.ControllerAlumno();
            //ControllerCuenta.Controller_Cuenta();
            ControllerComputadora.controllerComputer();
        }
    }
}


/*CLASE CONVERSOR////
           while (true)
           {
               double numero;
               Console.WriteLine("Ingresar numero en decimal: ");
               double.TryParse(Console.ReadLine(), out numero);
               Console.Clear();
               string numBinario = Conversor.ConvertDecToBin(numero);
               double numDecimal = Conversor.ConvertBinToDec(numBinario);
               Console.WriteLine("Decimal a binario: {0,15}\nBinario a decimal: {1,15}", numBinario, numDecimal);
           }*/
/*CLASE CALCULOAREA////
double ladoCuadrado, alturaT, baseT, radio;
Console.WriteLine("Ingrese el largo del lado del cuadrado: ");
double.TryParse(Console.ReadLine(),out ladoCuadrado);
Console.WriteLine("Area cuadrado: {0}", CalculoDeArea.CalcularCuadrado(ladoCuadrado));
Console.WriteLine("Ingrese la base del triangulo: ");
double.TryParse(Console.ReadLine(), out baseT);
Console.WriteLine("Ingrese la altura del triangulo: ");
double.TryParse(Console.ReadLine(), out alturaT);
Console.WriteLine("Area cuadrado: {0}", CalculoDeArea.CalcularTriangulo(baseT,alturaT));
Console.WriteLine("Ingrese el radio del circulo: ");
double.TryParse(Console.ReadLine(), out radio);
Console.WriteLine("Area cuadrado: {0}", CalculoDeArea.CalcularCirculo(radio));
Console.ReadKey();*/

/*///CALCULADORA
double valor1=0, valor2=0, resultado=0;
string operador = "", seguir ="s";
bool continuar;
do
{
    Console.Write("Ingrese el primer valor: ");
    continuar = double.TryParse(Console.ReadLine(), out valor1);
    Console.Clear();
    if (continuar)
    {
        Console.Write("Ingrese el operador: ");
        operador = Console.ReadLine();
        continuar = Calculadora.ValidarOperadores(operador);
    }
    Console.Clear();
    if (continuar)
    {
        Console.Write("Ingrese el primer valor: ");
        continuar = double.TryParse(Console.ReadLine(), out valor2);
    }
    Console.Clear();
    if (continuar)
    {
        resultado = Calculadora.Calcular(valor1, valor2, operador);
    }
    Console.Clear();
    if (continuar)
    {
        Calculadora.Mostrar(resultado);
    }
    if (!continuar)
    {
        Console.WriteLine("Error");
    }
    Console.WriteLine("Desea realizar otra operacion? s/n");
    seguir = Console.ReadLine().ToLower();
    Console.Clear();
} while (seguir != "n");*/
