using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * Abstracta, con el atributo Legajo.
     * Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
     * Método protegido y abstracto ParticiparEnClase.
     * Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
     */
    public abstract class Universitario : Persona
    {
        private int _legajo;       

        public int MyProperty
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

    }
}
