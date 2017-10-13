using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Sobracarga_Operadores
{
    class Dolar : Moneda
    {
        public Euro ToEuro()
        {
            Euro retorno = new Euro();
            retorno.SetValor(valor / 1.3642);
            return retorno;
        }
        public static Dolar operator +(Dolar valor1, Dolar valor2)
        {
            valor1.SetValor(valor1.GetValor() + valor2.GetValor());
            return valor1;
        }
        public static Dolar operator /(Dolar valor1, Dolar valor2)
        {
            valor1.SetValor(valor1.GetValor() / valor2.GetValor());
            return valor1;
        }
        public static Dolar operator *(Dolar valor1, Dolar valor2)
        {
            valor1.SetValor(valor1.GetValor() * valor2.GetValor());
            return valor1;
        }
        public static Dolar operator %(Dolar valor1, Dolar valor2)
        {
            valor1.SetValor(valor1.GetValor() % valor2.GetValor());
            return valor1;
        }

        //////////////////COMBINADAS////////////////////////////////

        public static Dolar operator +(Dolar valor1, Euro valor2)
        {
            valor1.SetValor(valor1.GetValor() + valor2.ToDolar().GetValor());
            return valor1;
        }
        public static Dolar operator +(Euro valor1, Dolar valor2)
        {
            valor2.SetValor(valor2.GetValor() + valor1.ToDolar().GetValor());
            return valor2;
        }
        public static Dolar operator /(Dolar valor1, Euro valor2)
        {
            valor1.SetValor(valor1.GetValor() / valor2.ToDolar().GetValor());
            return valor1;
        }
        public static Dolar operator /(Euro valor1, Dolar valor2)
        {
            valor2.SetValor(valor1.ToDolar().GetValor()/ valor2.GetValor());
            return valor2;
        }
    }

}
