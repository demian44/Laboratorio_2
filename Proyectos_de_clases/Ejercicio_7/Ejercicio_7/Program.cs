using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//07. Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y 
//calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema 
//con DateTime.Now).
//Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.
namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string fechaNacimiento;
            Console.WriteLine("Ingrese la fecha de nacimiento separado con  '/' (dd/mm/yyyy)");
            DateTime fecha;
            while (true)
            {
                fechaNacimiento = Console.ReadLine();
                //while (!DateTime.TryParse(fechaNacimiento, out fecha) || 0 < DateTime.Compare(fecha, DateTime.Today)) 
                //{
                //    Console.Clear();
                //    Console.WriteLine("Error.\nIngrese la fecha en formato correcto.");
                //    fechaNacimiento = Console.ReadLine();
                //    Console.WriteLine(":v");
                //}
                DateTime.TryParse(fechaNacimiento, out fecha);
                Console.WriteLine("Didas vividos: {0:#,#}" , int.Parse(((DateTime.Today - fecha).Days).ToString()));
                Console.WriteLine("v:");
                Console.ReadKey();
            }
        }

    }
}
