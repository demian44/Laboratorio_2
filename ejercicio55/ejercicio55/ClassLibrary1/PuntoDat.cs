using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PuntoDat : Archivo,IArchivos<PuntoDat>
    {
        public bool Guardar(string ruta)
        {
            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            return new PuntoDat();
        }
    }
}
