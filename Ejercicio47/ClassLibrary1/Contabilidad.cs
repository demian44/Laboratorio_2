using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Contabilidad<T, U>
    {
        private List<T> _egresos;

        private List<U> _ingresos;

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, T egreso)
        {
            if (egreso is Documento)
                contabilidad._egresos.Add(egreso);
            return contabilidad;
        }   

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (ingreso is Documento)
                contabilidad._ingresos.Add(ingreso);
            return contabilidad;         
        }
    }
}
