using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public static class GuuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            StreamWriter writer = null;
            try
            {
                writer = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo);
                writer.WriteLine(archivo);
                retorno = true;
            }
            catch (IOException exception) { }
            catch (Exception exception) { }
            finally
            {
                if (!ReferenceEquals(null, writer))
                    writer.Close();
            }

            return retorno;
        }
    }

}
