using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        private Paciente _pacienteActual;
        protected Random _tiempoAleatorio;

        public delegate void FinAtencionCliente(Paciente paciente, Medico medico);
        public event FinAtencionCliente AtencionFinalizada;

        #region Properties
        public Paciente AtenederA
        {
            set
            {
                if (!ReferenceEquals(value, null))
                    this._pacienteActual = value;
            }
        }

        public virtual string EstaAtendiendoA
        {
            get
            {
                string retorno = "No tiene pacientes.";
                if (!ReferenceEquals(this._pacienteActual, null))
                    retorno = this._pacienteActual.ToString();
                return retorno;
            }
        }
        #endregion

        public Medico(string nombre, string apellido) : base(nombre, apellido)
        {

        }

        protected abstract void Atender();

        public override string ToString()
        {
            return String.Format("Medico: {1} {0}", this._nombre, this._apellido);
        }
        protected void FinalizarAtencion()
        {
            
            this.AtencionFinalizada.Invoke(this._pacienteActual, this);
            this._pacienteActual = null;
        }
    }
}
