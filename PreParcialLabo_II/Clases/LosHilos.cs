using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class LosHilos
    {
        private int _id;
        private List<InfoHilo> misHilos;
        public string Bitacora
        {
            get 
            {

            }            
        }


        //LosHilos AgregarHilo(LosHilos hilos)
        //{
        //    return new LosHilos();
        //}

        LosHilos()
        {
            this._id = 0;
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            return new LosHilos();
        }

        public void RespuestaHilo(int id)
        { }

    }
}
