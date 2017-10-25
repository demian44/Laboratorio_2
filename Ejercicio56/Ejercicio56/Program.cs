using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio56
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Demian", "Boullon");
            Persona.Guardar(persona);
            Persona persona2 = Persona.LeerPersona();
            Console.WriteLine(persona2.ToString());
            Console.ReadKey();
        }
    }
}
