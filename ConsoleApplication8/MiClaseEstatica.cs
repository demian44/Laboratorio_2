using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public enum enumSexo
    {
        Femenino = 8,
        Masculino = 3
        
    }

    public static class MiClaseEstatica
    {

        public static  string nombre { get; set; }
        public static  enumSexo Sexo { get; set; }
        public static DateTime FechaNacimiento { get; set; }

        public static int Edad()
        {
            var edad = DateTime.Now.Year - FechaNacimiento.Year;

            if (FechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;

            return edad;
        }

    }
}
