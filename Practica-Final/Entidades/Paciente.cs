using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int _turno;
        private static int _ultimoTurnoDado;
        public int Turno
        {
            get { return this._turno; }
        }
        static Paciente()
        {
            _ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido) : base(nombre, apellido)
        {            
            this._turno= ++_ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido,int turno) : this(nombre, apellido)
        {
            this._turno = turno;
            _ultimoTurnoDado = turno;
        }

        public override string ToString()
        {
            return String.Format("Turno Nº{0}: {2}, {1}",this._turno,this._nombre,this._apellido);
        }
    }
}
