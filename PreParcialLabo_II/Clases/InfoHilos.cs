using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clases
{
    /*Clase InfoHilos:
     a. Atributo estático randomizer. El mismo se inicializará en un constructor de clase.
     b. El Thread hilo ejecutará el método Ejecutar.
    */

    public class InfoHilo
    {
        private const int MAX = 5;
        private const int MIN = 1;

        private IRespuesta<int> _callback;
        private Thread _hilo;
        private int _id;
        Random _randomizer;
        #region Methods        
        private void Ejecutar()
        {
            Thread.Sleep(this._randomizer.Next(MIN, MAX)*1000);
            this._callback.REspuestaHIlo(this._id);
        }

        private InfoHilo()
        {
            this._randomizer = new Random();            
        }

        public InfoHilo(int id, IRespuesta<int> callback) : this()
        {
            
            this._id = id;
            this._callback = callback;
            this._hilo = new Thread(this.Ejecutar);
            this._hilo.Start();
        }

        #endregion


    }
}
