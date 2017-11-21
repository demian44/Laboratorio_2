using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{        
    public class MGeneral : Medico, IMedico
    {
        public MGeneral(string nombre, string apellido) : base(nombre, apellido)
        {
            this._tiempoAleatorio = new Random();           
        }

        public void IniciarAtencion(Paciente p)
        {
            this.AtenederA = p;
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(this._tiempoAleatorio.Next(1500,2000));
            this.FinalizarAtencion();
        }

        
    }
}
