using System;
using System.Threading;

namespace Entidades
{

    public class MeGeneral : Medico, IMedico
    {
        #region Constructores
        public MeGeneral(string nombre, string apellido) : base(nombre, apellido)
        { }
        #endregion
               

        protected override void Atender()
        {
            Thread.Sleep(TiempoAleatorio.Next(1500, 2200));
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