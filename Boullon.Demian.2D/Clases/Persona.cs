using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Persona
    {
        private string _apellido;
        private string Apellido
        {
            get { return this._apellido; }
//          set { this._apellido = value; }
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
//          set { _nombre = value; }
        }
        abstract protected string FichaTecnica();

        protected string NombreCompleto()
        {
            string valorDeRetorno = String.Format("{0} {1}", this._nombre, this._apellido);
            return valorDeRetorno;
        }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }      
    }
}
