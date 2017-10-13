using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//17. Crear una clase llamada Cuenta y un enumerado
//llamado ETipoInteres, según se muestra en el siguiente
//diagrama:
//Se pide crear los métodos públicos(getters y setters)
//necesarios para poder manipular un objeto de tipo Cuenta, 
//sabiendo que dichos métodos deberán de realizar las
//validaciones correspondientes(en ningún caso se deberá
//pedir el reingreso de datos dentro del método).
namespace Ejercicio_13
{
    public enum EtipoInteres { TIM = 0, TAE = 1, TIR = 2 };
    class Cuenta
    {
        private string nombre;
        private long nroCuenta;
        private double saldo;
        private EtipoInteres tipoInteres;
        public string getNombre()
        {
            return nombre;
        }
        public long getNroCuenta()
        {
            return nroCuenta;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public EtipoInteres getTipoInteres()
        {
            return tipoInteres;
        }
        public bool setNombre(string valorNombre)
        {
            bool retorno = true;
            foreach (char letra in valorNombre)
            {
                if (!char.IsLetter(letra))
                {
                    retorno = false;
                    break;
                }
            }
            if (retorno)
            {
                nombre = valorNombre;
            }
            return retorno;
        }
        public bool setNroCuenta(long valorNroCuenta)
        {
            bool retorno = false;
            if (valorNroCuenta > 999999999 && valorNroCuenta < 9999999999)
            {
                nroCuenta = valorNroCuenta;
                retorno = true;
            }
            return retorno;
        }
        public bool setSaldo(double valorSaldo)
        {
            bool retorno = false;
            if (valorSaldo > 0)
            {
                saldo = valorSaldo;
                retorno = true;
            }
            return retorno;
        }
        public void setTipoInteres(EtipoInteres valorTipoIntereses)
        {
            tipoInteres = valorTipoIntereses;
        }

    }
}
