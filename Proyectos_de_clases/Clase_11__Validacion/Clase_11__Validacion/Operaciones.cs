using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class rangoEntero
    {
        protected int minimo;
        public int Minimo { get => minimo; set => minimo = value; }
        protected int maximo;
        public int Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }
        public rangoEntero(int min, int max)//Constructor para definir rango numerico al momento de crear el objeto.
        {
            minimo = min;
            maximo = max;
        }
    }
}
