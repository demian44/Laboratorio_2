using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


/*
 * 56. Crear un nuevo proyecto del tipo Consola.
 
 
 * iii. Crear un método estático Leer que deserialice un archivo y retorne una Persona.
 * iv. Sobrecargar el método ToString para mostrar los datos de la persona.
 * b. En el Main instanciar un objeto del tipo Persona e intentar serializarlo.
 * c. Luego intentar leer ese objeto serializado en una nueva instancia de persona y lo muestre
 * por pantalla.
 * d. Por cada excepción que lance la aplicación:
 * i. Generar un catch que la capture y la maneje.
 * ii. Luego corregir el problema que genera la excepción.
 * iii. Repetir el proceso hasta capturar todas las excepciones de forma individual (no
 * utilizar Exception).
 * iv. Los datos de la Persona guardada deben ser el nombre y el apellido, y coincidir con
 * los de la Persona leída.
 */

namespace Ejercicio56
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        
        /* ii. Crear un método estático llamado Guardar que reciba una persona y la serialice en
        un archivo.*/
        public static Guardar(Persona persona)
        {
            XmlTextWriter writer;// = new XmlTextWriter writer();
            XmlSerializer ser;   

        }
      

    }
}
