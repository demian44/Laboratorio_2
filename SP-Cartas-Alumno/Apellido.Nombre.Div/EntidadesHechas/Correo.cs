using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public class Correo
    {
        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;

        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #region Alumno

        /// <summary>
        /// a.	Controlar si el paquete ya está en la lista. En el caso de que esté, se lanzará la excepción TrackingIdRepetidoException.
        /// b.	Agregar el paquete a la lista de paquetes.
        /// c.	Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes.
        /// d.	Ejecutar el hilo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            if (!c.paquetes.Contains(p))
            {
                c.paquetes.Add(p);
                Thread nuevoHilo = new Thread(p.MockCicloDeVida);
                nuevoHilo.Start();
                c.mockPaquetes.Add(nuevoHilo);
            }                

            return c;
        }

        /// <summary>
        /// Utilizará string.Format con el siguiente formato "{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()
        /// para retornar los datos de todos los paquetes de su lista
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> l = (List<Paquete>)((Correo)elementos).paquetes;
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Paquete p in l)
            {
                stringBuilder.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Cerrará todos los hilos ACTIVOS
        /// </summary>
        public void FinEntregas()
        {
            foreach(Thread hilo in this.mockPaquetes)
            {
                hilo.Abort();
            }
        }

        #endregion
    }
}
