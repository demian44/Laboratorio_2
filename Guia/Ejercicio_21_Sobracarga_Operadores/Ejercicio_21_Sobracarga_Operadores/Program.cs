using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Construir dos clases: la clase Euro y la clase Dolar. Se debe lograr que los objetos de estas clases se puedan sumar, restar, comparar, 
 * incrementar y disminuir con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1.3642 dólares.
 * Además, tienen que ser compatibles entre sí y también con el tipo Double. Sobrecargar los operadores explicit y/o implicit. Nota: Las clases 
 * y el Program deben estar en namespaces distintos.
 */
namespace Ejercicio_21_Sobracarga_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar();
            Dolar dolar2 = new Dolar();
            dolar.SetValor(2 - 1.3642);
            Euro euro = new Euro();
            euro.SetValor(1);
            dolar2 = dolar + euro;
            euro = (dolar + euro).ToEuro();
            Console.WriteLine("Suma  en Dolares: Us${0,-5:.00} ( e{1:.00} )\nSuma en Euros:      e{2,-5:.00} ( Us${3:.00} )", dolar.GetValor(),dolar.ToEuro().GetValor(),euro.GetValor(),euro.ToDolar().GetValor());
            Console.ReadKey();            
        }
    }
}
