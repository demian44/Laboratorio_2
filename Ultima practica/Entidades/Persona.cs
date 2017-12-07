using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
                System.Threading.Thread.Sleep(200);
                this.Corriendo.Invoke((short)_avance.Next(0, this.VelocidadMaxima),this);
            }
        }

        public Persona(short velocidadMax, Carril carril, string nombre)
            : base(velocidadMax, carril)
        {
            this._nombre = nombre;
        }

        public delegate void CorrenCallBack(short avance, Persona corredor);
        public event CorrenCallBack Corriendo;

        public override void Guardar(string path)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = File.AppendText(path);
                streamWriter.WriteLine(this.ToString());
            }
            catch (Exception) { throw new NoSeGuardoException(); }
            finally { if (streamWriter != null) streamWriter.Close(); }
        }

        public override string ToString()
        {
            return string.Format("{1} en carril {0} a una velocidad máxima de {2}", this.CarrilElegido.ToString(), this._nombre, this.VelocidadMaxima);
        }

    }
}
