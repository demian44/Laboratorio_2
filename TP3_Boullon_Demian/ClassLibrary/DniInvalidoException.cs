using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{    
 
    public class DniInvalidoException : Exception
    {
        private string message;
        public DniInvalidoException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        public DniInvalidoException()
            : base()
        {

        }

        public DniInvalidoException(Exception e)
            : base()
        {   
            
        }        

        public DniInvalidoException(string message)
            : base("DNI invalido: " + message)
        {

        }

        public DniInvalidoException(string message, Exception e)
            : base("DNI invalido: " + message)
        {

        }
    }
 
}
