using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum TipoCompetencia { F1, MotoCross }
    public class Competencia
    {
        private short _cantidadCompetidores;
        public short CantidadCompetidor
        {
            get { return _cantidadCompetidores; }
            set { _cantidadCompetidores = value; }
        }

        private short _cantidadVueltas;
        public short CantidadVueltas
        {
            get { return _cantidadVueltas; }
            set { _cantidadVueltas = value; }
        }

        TipoCompetencia _tipo;
        TipoCompetencia Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        private List<VehiculoDeCarrera> _competidores;
        public VehiculoDeCarrera this[int i]
        {
            get { return this._competidores[i]; }
        }

        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>();
        }

        private Competencia(short cantidadVueltas, short cantidadCompetidores)
        {
            this._cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator ==(Competencia competencia, VehiculoDeCarrera auto)
        {
            bool retorno = false;
            bool continuar = true;
            if (competencia._tipo == TipoCompetencia.F1 &&  !(auto is AutoF1))
                continuar = false;
            else if (competencia._tipo == TipoCompetencia.MotoCross && !(auto is Motocross))
                continuar = false;

            if (!ReferenceEquals(null, competencia) && !ReferenceEquals(null, auto) && continuar)
            {
                foreach (AutoF1 autoEnCompetencia in competencia._competidores)
                {
                    if (autoEnCompetencia == auto)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        
        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }

        public static bool operator +(Competencia competencia, AutoF1 auto)
        {
            bool retorno = false;
            if (!ReferenceEquals(null, competencia) && !ReferenceEquals(null, auto))
            {
                if (competencia._competidores.Count < competencia._cantidadCompetidores && competencia != auto)
                {

                    competencia._competidores.Add(auto);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            bool retorno = false;
            if (!ReferenceEquals(null, competencia) && !ReferenceEquals(null, auto))
            {
                if (competencia == auto)
                {
                    competencia._competidores.Remove(auto);
                    retorno = true;
                }
            }
            return retorno;
        }

    }
}
