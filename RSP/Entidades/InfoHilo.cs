using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class InfoHilo
    {
        public IRespuesta<int> _callback;
        public Thread _hilo;
        public int _id;
        public static Random _randomizer;

        static InfoHilo()
        {
            _randomizer = new Random();
        }


        public InfoHilo(int id, IRespuesta<int> iRespuesta)
        {
            this._id = id;
            this._callback = iRespuesta;
            this._hilo = new Thread(this.Ejecutar);
            this._hilo.Start();
        }

        //private void Ejecutar()
        //{
        //    Thread.Sleep(_randomizer.Next(1000, 5000));
        //    this._callback.RespuestaHilo(this._id);
        //}

    }

    public static class ExtensionMethod
    {
        public static void Ejecutar(this InfoHilo infoHilo)
        {
            Thread.Sleep(InfoHilo._randomizer.Next(1000, 5000));
            infoHilo._callback.RespuestaHilo(infoHilo._id);
        }
    }
}
