using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        private int _id;
        private List<InfoHilo> _misHilos;

        public delegate void ElDelegado(string mensaje);
        public event ElDelegado AvisoFin;

        public string Bitacora
        {
            get { return Archivo.Leer(); }
            set { Archivo.Guardar(value); }
        }

        public LosHilos()
        {
            this._id = 0;
            _misHilos = new List<InfoHilo>();
        }

        //Método de clase AgregarHilo hará los siguientes pasos, en el siguiente orden:
        //i.Incrementará id.
        //ii.creará un nuevo InfoHilo y lo agregará a misHilos.

        private LosHilos AgregarHilo(LosHilos losHilos)
        {
            this._id++;
            InfoHilo infoHilo = new InfoHilo(this._id, this);
            this._misHilos.Add(infoHilo);
            return new LosHilos();
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = String.Format("Terminó el hilo {0}.", id);
            Archivo.Guardar(mensaje);
            this.AvisoFin.Invoke(mensaje);
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 0)
                throw new CantidadInvalidaException();

            for (int i = 0; i < cantidad; i++)
            {
                hilos.AgregarHilo(hilos);
            }
            return hilos;
        }
    }
}
