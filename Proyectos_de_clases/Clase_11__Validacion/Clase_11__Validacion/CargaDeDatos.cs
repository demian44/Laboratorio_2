using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace CargaDeDatos
{
    public static class CargarDatos
    {
        public static bool cargarEntero(ref int numero,string mensaje,string mensajeError,int intentos)
        {
            while (intentos > 0)
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero))
                    return true;
                Console.WriteLine(mensajeError);
                intentos--;
                Console.ReadKey();
            }
            return false;
        }
        public static bool cargarNumeroEnRango(ref int num,int min, int max, string msje, string msjError, int intentos)
        {
            Console.Clear();
            while (intentos > 0)
            {
                Console.WriteLine(msje);
                if (int.TryParse(Console.ReadLine(), out num) && Validacion.ValidarRangoNumerico(min,max,num))
                    return true;
                Console.Clear();
                Console.WriteLine(msjError);
                intentos--;
            }
            return false;
        }
    }
}
