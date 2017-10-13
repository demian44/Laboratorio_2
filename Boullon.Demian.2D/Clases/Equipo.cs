using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Equipo
    {
        enum Deportes { Basquet, Futbol, Handball, Rugby }
        static private Deportes _deportes;
        public Deportes Deporte
        {
            set { _deportes = value; }
        }
        private DirectorTecnico dt;
        private List<Jugador> _judgadores;
        private string _nombre;
        static Equipo()
        {
            _deportes = Deportes.Futbol;
        }
        private Equipo()
        {
            this._judgadores = new List<Jugador>();
        }
        private Equipo(string nombre, DirectorTecnico dt)
            : this()
        {
            this._judgadores = new List<Jugador>();
        }

        private Equipo(string nombre, DirectorTecnico dt)
            : this()
        {
            this._judgadores = new List<Jugador>();
        }
        static implicit operator String(Equipo equipo)
        {
            String retorno = String.Format("{0}");
        }
    }
}
