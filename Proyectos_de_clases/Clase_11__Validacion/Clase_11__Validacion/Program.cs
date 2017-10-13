using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
using Operaciones;
using CargaDeDatos;

namespace Clase_11__Validacion
{
    public class minMaximo
    {
        private int flag;
        private int minimo;
        public int Minimo { set { minimo = value; } get { return minimo; } }
        private int maximo;
        public int Maximo { set { maximo = value; } get { return maximo; } }
        public minMaximo()
        {
            flag = 0;
        }
        public void esMinimoOMaximo(int valor)
        {
            if (flag == 1)
            {
                if (maximo < valor)
                    maximo = valor;
                if (minimo > valor)
                    minimo = valor;
            }
            else
            {
                minimo = valor;
                maximo = valor;
                flag = 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rangoEntero rango = new rangoEntero(-100, 100);
            minMaximo minimoMaximo = new minMaximo();
            int numero = 0;
            for (int i = 0; i < 10; i++)
            {
                CargarDatos.cargarNumeroEnRango(ref numero,rango.Minimo,rango.Maximo, "Ingrese el " + (i+1).ToString() + " º numero (entre " + rango.Minimo.ToString() + " y  " + rango.Maximo.ToString() + "): ", "El numero debe estar entre " + rango.Minimo.ToString()  + " y  " + rango.Maximo.ToString() + ").", 5);
                minimoMaximo.esMinimoOMaximo(numero);
            }
            Console.WriteLine("Mminimo: {0}\nMaximo:{1}",minimoMaximo.Minimo,minimoMaximo.Maximo);
            Console.ReadKey();
        }
    }
}
