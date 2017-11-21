namespace Entidades
{
    public class Paciente : Persona
    {
        private int _turno;
        private static int _ultimoTurnoDado;
        public int Turno { get { return this._turno; } }

        #region Constructores
        static Paciente() { _ultimoTurnoDado = 0; }
        public Paciente(string nombre, string apellido) : base(nombre, apellido)
        {
            Paciente._ultimoTurnoDado++;
            this._turno = Paciente._ultimoTurnoDado;
        }
        public Paciente(string nombre, string apellido, int turno) : base(nombre, apellido)
        {
            this._turno = turno;
            Paciente._ultimoTurnoDado = turno;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Turno Nº{0}: {2}, {1}",this._turno,this._nombre,this._apellido);
        }

        #endregion
    }
}