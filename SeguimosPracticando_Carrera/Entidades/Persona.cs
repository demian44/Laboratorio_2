using Exceptions;
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

        public Persona(string nombre, short velocidadMax, Carril carril) : base(velocidadMax, carril)
        {
            this._nombre = nombre;
        }
        public override void Correr()
        {
            while (true)
            {
                short avance;
                System.Threading.Thread.Sleep(300);
                avance =(short)Corredor._avance.Next(0, this.VelocidadMaxima);
                this.Corriendo(avance, this);
            }
        }

        public override void Guardar()
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//LosPiolas.txt");
                streamWriter.WriteLine(this.ToString());
            }
            catch (NoSeGuardoException exception) { throw exception; }
            catch (Exception exception) { throw exception; }
            finally
            {
                if (!ReferenceEquals(streamWriter, null))
                    streamWriter.Close();
            }
        }

        public override string ToString()
        {
            string mensaje = String.Format("{0} en carril {1} a una velocidad máxima de {2}", this._nombre, this._carrilElgido, this.VelocidadMaxima);
            return mensaje;
        }


        public delegate void CorrenCallback(int avance, Persona corredor);
        public event CorrenCallback Corriendo;

    }
}
