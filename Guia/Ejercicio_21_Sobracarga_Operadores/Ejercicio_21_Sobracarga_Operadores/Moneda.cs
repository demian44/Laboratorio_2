using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Sobracarga_Operadores
{
    class Moneda
    {
        protected double valor;
        public double GetValor()
        {
            return valor;
        }
        public void SetValor(double numero)
        {
            valor = numero;
        }
        public float ToFloat()
        {
            return (float)valor;
        }
    }
}
