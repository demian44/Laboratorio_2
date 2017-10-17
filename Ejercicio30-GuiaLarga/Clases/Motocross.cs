using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Motocross : VehiculoDeCarrera
    {
        public Motocross(short numero, string escuderia) : base(numero, escuderia)
        {
            this._cilindrada = 0;
        }

        public Motocross(short numero, string escuderia,short cilindrada) : base(numero, escuderia)
        {
            this._cilindrada = cilindrada;
        }

        private short _cilindrada;
        public short Cilindrada
        {
            get { return _cilindrada; }
            set { _cilindrada = value; }
        }

        public override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarDatos());
            if(this._cilindrada!=0)
                retorno.AppendLine("Cilindrada: " + this._cilindrada.ToString());
            return retorno.ToString(); 
        }


    }
}
