using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Carril { Carril1, Carril2 }
    public abstract class Corredor
    {
        protected static Random _avance;
        protected Carril _carrilElegido;
        private short _velocidadMaxima;

        static Corredor()
        {
            _avance = new Random();
        }

        //El atributo _velocidadMax será privado. La propiedad pública VelocidadMaxima 
        //validará que la velocidad máxima nunca podrá superar el valor 10
        public Carril CarrilElegido
        {
            get { return this._carrilElegido; }
        }

        public short VelocidadMaxima
        {
            set
            {
                if (value <= 10 && value >= 0)
                    this._velocidadMaxima = value;
                else throw new Exception("Velocidad invalida.");
            }
            get
            {
                return this._velocidadMaxima;
            }
        }

        public abstract void Correr();

        public virtual void Guardar(string Path)
        {
            throw new NotImplementedException();
        }

    }
}
