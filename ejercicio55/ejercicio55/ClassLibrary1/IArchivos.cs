using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IArchivos<T>
    {
        public bool Guardar(string ruta);

        public T Leer(string ruta);
    }
}
