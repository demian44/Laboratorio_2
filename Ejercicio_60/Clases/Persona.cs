using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _id;

        public string Nombre
        {
            get { return this._nombre; }
        }
        public string Apellido
        {
            get { return this._apellido; }
        }
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;            
        }
        public Persona(int id, string nombre, string apellido):this(nombre, apellido)
        {              
            this._id = id;
        }


    }
}

