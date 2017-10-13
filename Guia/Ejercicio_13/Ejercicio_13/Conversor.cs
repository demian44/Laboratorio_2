using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *13. Desarrollar una clase llamada ‗Conversor’, que posea dos métodos de clase (estáticos): 
 * string DecimalBinario(double). Convierte un número de decimal a binario. double BinarioDecimal(string).
 * Convierte un número binario a decimal. 
 **/
namespace Ejercicio_13
{
    static class Conversor
    {
        public static string ConvertDecToBin(double numDec)
        {
            string numBin = "";
            double resto;
            do
            {
                resto = numDec % 2;
                numDec = Math.Truncate(numDec / 2);
                numBin = resto.ToString() + numBin;
            } while (numDec / 2 >= 1);
            if (numDec == 1)
            {
                numBin = numDec.ToString() + numBin;
            }
            return numBin;
        }
        public static double ConvertBinToDec(string numBin)
        {
            double numDec = 0;
            int cantidadDeDigitos = numBin.Length;
            foreach (char digito in numBin)
            {
                cantidadDeDigitos--;
                numDec = numDec + (Math.Pow(2, cantidadDeDigitos) * Convert.ToDouble(digito.ToString()));
            }
            return numDec;
        }
    }
}
