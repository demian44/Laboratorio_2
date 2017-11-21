using System;
using System.Threading;

namespace Entidades
{

    public class MeEspecialista : Medico, IMedico
    {
        private Especialidad _especialidad;
        #region Constructores
        public MeEspecialista(string nombre, string apellido,Especialidad especialidad) : base(nombre, apellido)
        {
            this._especialidad = especialidad;
        }
        #endregion
               
        protected override void Atender()
        {
            Thread.Sleep(TiempoAleatorio.Next(5000, 10000));
            this.FinalziarAtencion();
        }
        

        #region Methods

        public void IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }

        #endregion
    }
}