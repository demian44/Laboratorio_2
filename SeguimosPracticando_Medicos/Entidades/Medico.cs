using System;

namespace Entidades
{
    public enum Especialidad { Traumatologo, Odontologo }
    public abstract class Medico : Persona
    {
        private Paciente _pacienteActual;
        static protected Random TiempoAleatorio;

        public string EstaAtendiendoA { get { return this._pacienteActual.ToString(); } }
        public Paciente AtenderA { set { this._pacienteActual = value; } }


        #region Constructores
        static Medico() { Medico.TiempoAleatorio = new Random(); }
        public Medico(string nombre, string apellido) : base(nombre, apellido)
        { }

        #endregion

        #region Eventos y Delegados
        public delegate void FinAtencionPaciente(Paciente paciente, Medico medico);
        public event FinAtencionPaciente AtencionFinalizada;
        #endregion

        #region Methods
        protected abstract void Atender();

        protected void FinalziarAtencion()
        {
            this.AtencionFinalizada.Invoke(this._pacienteActual, this);
            this.AtenderA = null;
        }

        public override string ToString()
        {
            return this._apellido + " " + this._nombre;
        }

        #endregion
    }
}