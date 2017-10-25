using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Archivo
    {
        bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException();
            }
            return true;
        }
    }
}
