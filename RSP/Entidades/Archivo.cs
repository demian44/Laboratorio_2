using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivo
    {
        public static string Leer()
        {
            try
            {
                string retorno = String.Empty;
                StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//bitacora.txt");
                retorno = streamReader.ReadToEnd();
                streamReader.Close();
                return retorno;
            }
            catch
            {
                return String.Empty;
            }
        }

        public static bool Guardar(string mensaje)
        {
            try
            {
                StreamWriter streamWriter = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//bitacora.txt");
                streamWriter.WriteLine(mensaje);
                streamWriter.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
