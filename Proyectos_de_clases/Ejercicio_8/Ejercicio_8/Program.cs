using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//08. Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas en el mes de ‗n‘ 
//empleados de una fábrica.
//Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de 
//horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $ 150, y al total de todas esas operaciones 
//restarle el 13% en concepto de descuentos.Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total
//a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.Nota: Utilizar estructuras 
//repetitivas y selectivas.

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_hora, horas_trabajadas, años_antiguedad,bruto;
            double neto, descuento, total=0;
            string nombre;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del empleado:");
                nombre=Console.ReadLine();
                Console.WriteLine("Ingrese el valor de la hora:");
                int.TryParse(Console.ReadLine(), out valor_hora);
                Console.WriteLine("Ingrese la antiguedad: ");
                int.TryParse(Console.ReadLine(), out años_antiguedad);
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                int.TryParse(Console.ReadLine(), out horas_trabajadas);
                bruto = (valor_hora * horas_trabajadas + años_antiguedad * 150);
                neto = bruto * 0.87;
                descuento = bruto - neto;
                total += neto;
                Console.Clear();
                Console.WriteLine("-----------------------\nNombre: {0}\nAntiguedad: {1}\nValor hora: {2:N}\nSueldo bruto: {3:0.00}\nSueldo neto: {4:N}\nDescuento: {5:0.00}\nTotal ueldos: {6:0,00}", nombre, años_antiguedad, valor_hora, bruto, neto,descuento, total);
                Console.ReadKey();

            } while (true);

        }
    }

}
