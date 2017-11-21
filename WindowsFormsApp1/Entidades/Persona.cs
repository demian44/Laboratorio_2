using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : Corredor
    {
        private string _nombre;

        public override void Correr()
        {
            while (true)
            {
                Thread.Sleep(300);
                this.Corriendo.Invoke(_avance.Next(0, this.VelocidadMaxima), this);
            }            
        }

        public Persona(string nombre, short velocidadMax, Carril carril)
        {
            this._nombre = nombre;
            this.VelocidadMaxima = velocidadMax;
            this._carrilElegido = carril;
        }

        public override void Guardar(string Path)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = File.AppendText(Path);
                streamWriter.WriteLine(this.ToString());
            }
            catch (NoSeGuardoException exception)
            {
                throw exception;
            }
            finally
            {
                if (!ReferenceEquals(null, streamWriter))
                    streamWriter.Close();
            }
        }

        public override string ToString()
        {
            string retorno = String.Format("{0} en carril {1} a una velocidad máxima de {2}", this._nombre, this.CarrilElegido.ToString(), this.VelocidadMaxima);
            return retorno;
        }

        public delegate void CorrenCallback(int avance, Persona corredor);
        public event CorrenCallback Corriendo;
    }
}
