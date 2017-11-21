using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        public enum Especialidad { Traumatologo, Odontologo }
        private Especialidad _especialidad;
        public MEspecialista(string nombre, string apellido,Especialidad especialidad) : base(nombre, apellido)
        {
            this._tiempoAleatorio = new Random();
            this._especialidad = especialidad;
        }

        public void IniciarAtencion(Paciente p)
        {
            this.AtenederA = p;
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }
        public override string ToString()
        {
            return base.ToString() + ", " + this._especialidad.ToString();
        }

        protected override void Atender()
        {
            Thread.Sleep(this._tiempoAleatorio.Next(5000, 10000));
            this.FinalizarAtencion();
        }


    }
}
