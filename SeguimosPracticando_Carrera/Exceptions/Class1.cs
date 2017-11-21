using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NoSeGuardoException : IOException
    {
        public NoSeGuardoException() : base("No se pudo guardar al corredor.")
        { }
    }
}
