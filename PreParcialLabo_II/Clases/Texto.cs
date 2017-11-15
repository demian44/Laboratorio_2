using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public class Texto
    {
        public string leer()
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                if (File.Exists(Environment.SpecialFolder.Desktop.ToString()))
                {
                    StreamReader streamReader = new StreamReader(Environment.SpecialFolder.Desktop.ToString());
                    while (!streamReader.EndOfStream)
                        stringBuilder.AppendLine(streamReader.ReadLine());
                    streamReader.Close();
                }
            }
            catch (IOException excepcion)
            {
                throw excepcion;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return stringBuilder.ToString();
        }        
    }
}