using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugador : Persona
    {
        private int _numero;

        private bool _esCapitan;

        public Jugador(string nombre, string apellido)
            : base(nombre, apellido)
        {
            this._esCapitan = false;
            this._numero = 0;
        }

        public Jugador(string nombre, string apellido, int numero, bool isCapitan)
            : base(nombre, apellido)
        {
            this._esCapitan = isCapitan;
            this._numero = numero;
        }

        protected override string FichaTecnica()
        {
            string mensajeDeretorno;
            if (this._esCapitan)
                mensajeDeretorno = String.Format("{0} -- {1} -- {2}", this.NombreCompleto(), "Capitan del equipo", this._numero);
            else
                mensajeDeretorno = String.Format("{0} -- {1} ", this.NombreCompleto(), this._numero);
            return mensajeDeretorno;
        }

        public static bool operator ==(Jugador jugador_1, Jugador jugador_2)
        {
            bool retornoBooleano = false;
            if (jugador_1._numero == jugador_2._numero && jugador_1.ToString() == jugador_2.ToString())
                retornoBooleano = true;
            return retornoBooleano;
        }

        public override bool Equals(object obj)
        {
            return (this == obj);
        }

        public static bool operator !=(Jugador jugador_1, Jugador jugador_2)
        {
            return !(jugador_1 == jugador_2);
        }

        public static explicit operator int(Jugador jugador_1)
        {
            return jugador_1._numero;
        }
        public override string ToString()
        {
            return this.FichaTecnica();
        }

    }
}
