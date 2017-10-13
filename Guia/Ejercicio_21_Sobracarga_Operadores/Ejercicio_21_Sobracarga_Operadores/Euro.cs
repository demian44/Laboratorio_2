using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21_Sobracarga_Operadores
{
    class Euro : Moneda
    {
        public Dolar ToDolar()
        {
            Dolar retorno = new Dolar();
            retorno.SetValor(valor * 1.3642);
            return retorno;
        }

        public static Euro operator +(Euro valor1, Euro valor2)
        {
            valor1.SetValor(valor1.GetValor() + valor2.GetValor());
            return valor1;
        }
        public static Euro operator *(Euro valor1, Euro valor2)
        {
            valor1.SetValor(valor1.GetValor() * valor2.GetValor());
            return valor1;
        }
        public static Euro operator /(Euro valor1, Euro valor2)
        {
            valor1.SetValor(valor1.GetValor() / valor2.GetValor());
            return valor1;
        }
        public static Euro operator %(Euro valor1, Euro valor2)
        {
            valor1.SetValor(valor1.GetValor() % valor2.GetValor());
            return valor1;
        }

        //////////////////COMBINADAS////////////////////////////////

      /*  public static Euro operator +(Dolar valor1, Euro valor2)
        {
            valor2.SetValor(valor1.ConvertirAEuro().GetValor() + valor2.GetValor());
            return valor2;
        }
        public static Euro operator +(Euro valor1, Dolar valor2)
        {
            valor1.SetValor(valor2.ConvertirAEuro().GetValor() + valor1.GetValor());
            return valor1;
        }*/
        public static Euro operator /(Dolar valor1, Euro valor2)
        {
            valor2.SetValor(valor1.ToEuro().GetValor() / valor2.GetValor());
            return valor2;
        }
        public static Euro operator /(Euro valor1, Dolar valor2)
        {
            valor1.SetValor(valor1.GetValor() / valor2.ToEuro().GetValor());
            return valor1;
        }
    }
}
