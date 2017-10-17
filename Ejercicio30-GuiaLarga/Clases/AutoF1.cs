using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short _caballosDeFuerza;


        public short CaballosDeFuerza
        {
            get { return this._caballosDeFuerza; }
            set { this._caballosDeFuerza = value; }
        }

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        { }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this._caballosDeFuerza = caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            bool retorno = false;
            if (auto1 == auto2)
                if (auto1._caballosDeFuerza == auto2._caballosDeFuerza)
                    retorno = true;
            return retorno;
        }

        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }

        public override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.MostrarDatos());
            retorno.AppendLine("Caballos de fuerza: " + this._caballosDeFuerza.ToString());
            return retorno.ToString();
        }

    }
}
