using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public static class ControllerCuenta
    {
        public static void Controller_Cuenta()
        {
            long nroCuenta;
            int tipoInteres;
            double saldo;
            string nombre;
            EtipoInteres tipoIntereses;
            Cuenta[] listaCuentas = new Cuenta[3];
            for (int i=0; i < 3; i++)
            {
                Console.Clear();
                listaCuentas[i] = new Cuenta();
               /* Console.WriteLine("Ingresar numero de cuenta(numero de 10 digitos): ");
                while(!long.TryParse(Console.ReadLine(), out nroCuenta) || !listaCuentas[i].setNroCuenta(nroCuenta))
                {
                    Console.WriteLine("Error al introducir el numero de cuenta. Reintento: ");
                }
                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                while (!listaCuentas[i].setNombre(nombre))
                {
                    Console.WriteLine("Error al introducir el nombre. Reintente: ");
                    nombre = Console.ReadLine();
                }
                Console.WriteLine("Ingrese el tipo de intereses TAE - TIM - TIR\n1-TAE\n2.TIM\n3-TIR");
                bool error = true;
                while (error)
                {
                    int.TryParse(Console.ReadLine(), out tipoInteres);
                    tipoInteres--;
                    switch (tipoInteres)
                    {
                        case 0:
                            listaCuentas[i].setTipoInteres(EtipoInteres.TAE);
                            error = false;
                            break;
                        case 1:
                            listaCuentas[i].setTipoInteres(EtipoInteres.TAE);
                            error = false;
                            break;
                        case 2:
                            listaCuentas[i].setTipoInteres(EtipoInteres.TAE);
                            error = false;
                            break;
                        default:
                            Console.WriteLine("Error. Reintente: ");
                            break;
                    }
                }*/
                Console.WriteLine("Ingrese el saldo: ");
                while(!double.TryParse(Console.ReadLine(),out saldo))
                {
                    Console.Clear();
                    Console.WriteLine("Error. Re-ingrese el saldo: ");
                }
                listaCuentas[i].setSaldo(saldo);



            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nombre: {0} - Nro de cuenta: {1} - Saldo: {2} - Tipo interes: {3}", listaCuentas[i].getNombre(), listaCuentas[i].getNroCuenta(), listaCuentas[i].getSaldo(), listaCuentas[i].getTipoInteres());
            }
            Console.ReadKey();

        }
    }
}
