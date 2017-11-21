using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //e.El operador + lanzará la excepción CantidadInvalidaException en el caso de que la 
    //cantidad sea menor a 1.
    //f.Si cantidad es mayor a 0, deberá agregar tantos hilos cómo indique dicha cantidad.

    public class LosHilos : IRespuesta<int>
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Bitacora.txt";

        //a. El atributo id deberá inicializar el 0.
        private int _id;
        private List<InfoHilo> misHilos;
        
        #region Constructor
        public LosHilos() { this._id = 0; this.misHilos = new List<InfoHilo>(); }

        #endregion
        //b.La propiedad Bitacora utilizará el set para generar un archivo en el escritorio de 
        //la máquina donde se ejecute llamado "bitacora.txt". El get retornará el contenido del 
        //mismo archivo.
        public string Bitacora
        {
            get
            {
                string retorno = "Error de lectura.";
                Archivos.Leer(_path, out retorno);
                return retorno;
            }
            set
            {
                Archivos.Guardar(_path, value);
            }
        }

        //c.Método de clase AgregarHilo hará los siguientes pasos, en el siguiente orden:
        //i.Incrementará id.
        //ii.creará un nuevo InfoHilo y lo agregará a misHilos.
        LosHilos AgregarHilo(LosHilos losHilos)
        {
            losHilos._id++;
            InfoHilo infoHilos = new InfoHilo(losHilos._id, losHilos);
            losHilos.misHilos.Add(infoHilos);
            return losHilos;
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                hilos.AgregarHilo(hilos);                
            }                
            return hilos;
        }

        //d.RespuestaHilo hará los siguientes pasos, en el siguiente orden: i.Creará un mensaje
        //con el siguiente formato: "Terminó el hilo {0}.".
        //ii.Guardará el mensaje en la bitácora.
        //iii.Ejecutará el evento AvisoFin.
        public void REspuestaHIlo(int id)
        {
            string mensaje = string.Format("Terminó el hilo {0}",id);
            this.Bitacora = mensaje;
            AvisoFin.Invoke(mensaje);
        }

        public delegate void MyDelegate(string mensaje);
        public event MyDelegate AvisoFin;

    }
}
