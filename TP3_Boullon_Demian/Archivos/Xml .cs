using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : ITexto
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;            
            if(archivo != String.Empty)
            XmlSerializer xmlSerializer;
            XmlTextWriter xmlWriter = new XmlTextWriter(archivo,Encoding.ASCII);
            xmlSerializer = new XmlSerializer(typeof(T));
            return retorno;
        }
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            StreamReader streamWriter;
            if (File.Exists(archivo))
            {
                streamWriter = new StreamReader(archivo);
                datos = streamWriter.ReadToEnd();
                streamWriter.Close();
                retorno = true;
            }
            else
                datos = String.Empty;

            return retorno;
        }
    }
}
