using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Entidades
{
    [Serializable]
    public class MeGeneral : Medico, IMedico
    {
        #region Constructores
        public MeGeneral(string nombre, string apellido) : base(nombre, apellido)
        {
            FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\pepe.bin", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, this);
            fileStream.Close();
        }
        #endregion
               
        public MeGeneral() { }

        protected override void Atender()
        {
            Thread.Sleep(TiempoAleatorio.Next(1500, 2200));
            this.FinalziarAtencion();
        }
        

        #region Methods

        public void IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }

        #endregion
    }
}