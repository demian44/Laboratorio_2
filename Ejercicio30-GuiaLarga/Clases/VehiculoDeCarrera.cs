using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class VehiculoDeCarrera
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        #region Propiedades
        public short CantidadCombustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this._escuderia; }
            set { this._escuderia = value; }
        }

        public short Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        #endregion

        #region Metodos
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this._enCompetencia = false;
            this._vueltasRestantes = 0;
            this._cantidadCombustible = 0;
        }

        //  Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, 
        //la cantidad
        //de vueltasRestantes será igual a la cantidadVueltas de Competencia y se
        //le asignará un
        //número random entre 15 y 100 a cantidadCombustible.
        public void IniciarCarrera(short vueltasRestantes)
        {
            Random random = new Random();
            this._enCompetencia = true;
            this._vueltasRestantes = vueltasRestantes;
            this._numero = (short)random.Next(15, 100);
        }

        public virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Numero: {0} \n Escuderia: {1} \n Vueltas Restantes: {2} \nCantidad de Combustible: {3}", this._numero, this._escuderia, this._vueltasRestantes, this._cantidadCombustible);
            if (this._enCompetencia)
                retorno.AppendLine("Estado: Esta en carrera.");
            else
                retorno.AppendLine("Estado: No esta en carrera.");

            return retorno.ToString();
        }
        #endregion

        #region Operators
        public static bool operator ==(VehiculoDeCarrera auto1, VehiculoDeCarrera auto2)
        {
            bool retorno = false;
            if (!ReferenceEquals(null, auto1) && !ReferenceEquals(null, auto2))
            {
                if (auto1._numero == auto2._numero && auto1._escuderia == auto2._escuderia)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(VehiculoDeCarrera auto1, VehiculoDeCarrera auto2)
        {
            return !(auto1 == auto2);
        }
        #endregion

    }
}
