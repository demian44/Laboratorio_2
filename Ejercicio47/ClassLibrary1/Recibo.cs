using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Recibo : Documento
    {
        public Recibo() 
        {
            this._numero = 0; 
        }

        public Recibo(int numero) : base(numero)
        { }
    }
}
