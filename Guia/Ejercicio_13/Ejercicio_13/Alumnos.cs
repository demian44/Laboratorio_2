using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Alumno
    {
        public static int generadorLegajo = 0;
        private int nota1;
        private int nota2;
        private float notaFinal;
        public string apellido;
        private int legajo;
        public string nombre;
        public Alumno()
        {
            nota1 = -1;
            nota2 = -1;
            notaFinal = -1;
            legajo = generadorLegajo;
            generadorLegajo++;
        }
        public void calcularFinal()
        {
            Random random = new Random();
            if (nota1 > 4 && nota2 > 4)
            {
                notaFinal = random.Next(0, 10);
            }
        }
        public string Nombre
        {
            set {nombre = value;}
            get { return nombre; }
        }
        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public bool Estudiar(int nota_1, int nota_2)
        {
            bool retorno = false;
            if (nota_1 >= 0 && nota_1 <= 10 && nota_2 >= 0 && nota_2 <= 10)
            {
                nota1 = nota_1;
                nota2 = nota_2;
                retorno = true;
            }
            return retorno;
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nLegajo: {2} ", nombre, apellido, legajo);
            if (nota1 > -1)
            {
                Console.WriteLine("Nota primer parcial: {0}\nNota segundo parcial: {1}", nota1, nota2);
            }
            if (notaFinal > -1)
            {
                Console.WriteLine("Nota final: " + notaFinal);
            }
        }
    }
}
