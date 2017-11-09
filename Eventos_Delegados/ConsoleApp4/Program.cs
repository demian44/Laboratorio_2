using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Clase ejemplo = new Clase();
            ClaseEvento claseEvento = new ClaseEvento();
            claseEvento.MiEvento += ejemplo.funcion1;//Dentro del evento puedo meter el metodo que coresponde al objeto instanciado. 
            claseEvento.MiEvento += ejemplo.funcion2;
            claseEvento.MiEvento += ejemplo.funcion2;
            claseEvento.MiEvento += Clase.funcion3;
            claseEvento.LanzarEvento(8);            
            Console.ReadKey();
        }

        public class ClaseEvento // Contiene el evento y el delegado que permite cargar los metodos.
        {
            public delegate void miDelegado(int i);

            public event miDelegado MiEvento;      
            
            public void LanzarEvento(int i)
            {
                this.MiEvento.Invoke(i);
            }
        }

        public class Clase //Tiene los metodos que van a ser usados en el evento.
        {
            int numero;
            public Clase()
            {
                this.numero = 7;
            }
            public void funcion1(int z)
            {
                Console.WriteLine((z * this.numero).ToString());
            }
            public void funcion2(int z)
            {
                Console.WriteLine((z * 3 * this.numero).ToString());
            }
            public static void funcion3(int z)
            {
                Console.WriteLine((z * z).ToString());
            }
        }

    }
}
