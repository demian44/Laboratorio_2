using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        public enum Carril { Carril_1, Carril_2 }
        protected static Random _avance;
        protected Carril _carrilElgido;
        private short _velocidadMáxima;

        public short VelocidadMaxima
        {
            set
            {
                if (value > 10)
                    throw new Exception("Valor supera la velocidad máxima.");
                else if (value < 0)
                    throw new Exception("Valor inválido para velocidad máxima.");
                else
                    this._velocidadMáxima = value;
            }

            get { return this._velocidadMáxima; }
        }
        public Carril CarrilElegido { get { return this._carrilElgido; } }

        public abstract void Correr();

        public virtual void Guardar() { throw new NotImplementedException(); }

        static Corredor() { _avance = new Random(); }

        protected Corredor(short velocidadMax, Carril carril)
        {
            this._carrilElgido = carril;
            this._velocidadMáxima = velocidadMax;
        }
    }
}
