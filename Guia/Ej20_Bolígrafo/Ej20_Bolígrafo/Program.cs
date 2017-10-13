using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20_Bolígrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo[] BoliList = new Boligrafo[8];
            BoliList[0] = new Boligrafo(ConsoleColor.Blue, E_Estado.lleno);
            
            Console.ForegroundColor= BoliList[0].Pintar(1);
            Console.WriteLine(":V");
            Console.ResetColor();
            Console.WriteLine(":V");
            Console.ReadKey();

        }
    }
}
