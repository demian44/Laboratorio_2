using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Documento
    {
        protected int _numero;
        public Documento(int numero)
        {
            this._numero = numero;
        }
        protected Documento()
        { }

    }
}
