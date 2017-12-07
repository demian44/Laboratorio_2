using System;

namespace Entidades
{
    [Serializable]
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;


        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}