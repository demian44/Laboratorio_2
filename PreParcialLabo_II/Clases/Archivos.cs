using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Archivos
    {
        private static StreamReader streamreader;
        private static StreamWriter streamWriter;

        public static bool Leer(string path, out string mensaje)
        {
            bool retorno = false;
            try
            {
                streamreader = new StreamReader(path);
                mensaje = streamreader.ReadToEnd();
                retorno = true;
            }
            catch (IOException iOException) { mensaje = iOException.Message; }
            catch (Exception exception) { throw exception; }
            finally { streamreader.Close(); }
            return retorno;
        }

        public static bool Guardar(string path, string mensaje)
        {
            bool retorno = false;
            try
            {
                streamWriter = File.AppendText(path);
                streamWriter.WriteLine(mensaje);
            }
            catch (IOException iOException) { throw iOException; }
            catch (Exception exception) { throw exception; }
            finally { streamWriter.Close(); }

            return retorno;
        }
    }
}
