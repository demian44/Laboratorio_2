using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr4 = new string[3];
            arr4[0] = "one";
            arr4[1] = "two";
            arr4[2] = "three";
            

            MiClaseEstatica.FechaNacimiento = DateTime.Parse("2000-08-12");

            Console.WriteLine(MiClaseEstatica.Edad());
            Console.ReadLine();


        }
    }
}
