using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Clase Persona:
 *  Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
 *  Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y
 * 89999999. Caso contrario, se lanzará la excepción DniInvalidoException.
 *  Sólo se realizarán las validaciones dentro de las propiedades.
 *  Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se
 * cargará.
 *  ToString retornará los datos de la Persona.
 * 
 * */
namespace ClassLibrary
{
    public abstract class Persona
    {
        private string _nombre;      
        private string _apellido;
        private string _nacionalidad;
        private string _dni;

        #region Propiedades

        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if(OnlyLetters(value))
                    this._nombre = value;
            }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set
            {
                if (OnlyLetters(value))
                    this._nombre = value;
            }
        }

        public string Nacionalidad
        {
            get { return this._nacionalidad; }
            set
            {
                if (OnlyLetters(value))
                    this._nacionalidad = value;
            }
        }

        #endregion


        #region Metodos
        /// <summary>
        /// Recorre la cadena de caracteres en busca de un elemento que no sea una letra.
        /// En caso de encontrar dicho elemento retorna false, caso contrario, true.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool OnlyLetters(string text)
        {
            bool retorno = true;
            foreach (char caracter in text)
            {
                if (!char.IsLetter(caracter))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el dni esté entre 1 y 89999999.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        private bool ValidarDni(int dni)
        {
            bool retorno = false;
            if (!ReferenceEquals(null, dni))
            {
                if (dni > 0 && dni < 90000000)
                    retorno = true;
            }

            return retorno;
        }
        #endregion

        
    }
}
