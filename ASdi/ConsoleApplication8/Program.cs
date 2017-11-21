using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase1 clase1 =  new Clase1();
            clase1.MetodoExtension(2);            
        }

       
    }
    public sealed class Clase1
    {
        public int pepe;
    }

    public static class MetodosExtendidos
    {
        public static void MetodoExtension(this Clase1 clase1, int i)
        {
            clase1.pepe = i * 45;
        }

    }
}
