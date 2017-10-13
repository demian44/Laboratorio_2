using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumnos;
using Validaciones;

namespace ControllerAlumnos
{
    public static class ControllerALumno
    {
        public static void ControllerAlumno()
        {
            Alumno[] Alumnos = new Alumno[3];
            int i = 0, nota1, nota2;
            while (i < 3)
            {
                Alumnos[i] = new Alumno();
                Console.WriteLine("Ingresar Nombre Alumno {0}: ", i+1);
                Alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresar Apellido Alumno {0}: ", i + 1);
                Alumnos[i].apellido = Console.ReadLine();
                Console.WriteLine("ingresar primera nota: ");
                if(int.TryParse(Console.ReadLine(), out nota1))
                    Console.WriteLine("ingresar segunda nota: ");
                if(int.TryParse(Console.ReadLine(), out nota2))
                    Alumnos[i].Estudiar(nota1,nota2);
                Alumnos[i].calcularFinal();
                i++;
            }
            i = 0;
            while (i < 3)
            {
                Alumnos[i].Mostrar();
                i++;
            }
            Console.ReadKey();
        }
    }
}
