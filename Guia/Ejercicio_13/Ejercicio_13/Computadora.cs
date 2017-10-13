using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    enum EMarca { Asus, Apple, Toshiba, IBM }
    enum EProcesador { Intel_Core_i7, ADM_Phenom_II, ADM_Atlon_II, Intel_Celeron_430, ADM_Sempron_145 }
    class Computadora
    {
        private bool estaEncendida;
        private EMarca marca;
        private float peso;
        private EProcesador procesador;

        public bool GetEstaEncendida()
        {
            return estaEncendida;
        }
        public EMarca GetMarca()
        {
            return marca;
        }
        public float GetPeso()
        {
            return peso;
        }
        public EProcesador GetProcesador()
        {
            return procesador;
        }
        public bool SetEstaEncedida(bool encender)
        {
            bool retorno = false;
            if (encender != estaEncendida)
            {
                estaEncendida = encender;
                retorno = true;
            }
            return retorno;
        }
        public void SetMarca(EMarca valueMarca)
        {
            marca = valueMarca;
        }
        public bool SetPeso(float valuePeso)
        {
            bool retorno = false;
            if (valuePeso > 0)
            {
                peso = valuePeso;
                retorno = true;
            }
            return retorno;
        }
        public void SetProcesador(EProcesador valueProcesador)
        {
            procesador = valueProcesador;
        }
        public Computadora(bool falso)
        {
            estaEncendida = falso;
        }
}
}
