using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Persona;

namespace Ultima_practica
{
    public partial class lblWachin1 : Form
    {

        private List<Persona> _corredores;
        private List<Thread> _corredoresActivos;
        private bool _hayGanador;
        public lblWachin1()
        {
            InitializeComponent();
        }


        private void AnalizarCarrera(ProgressBar progressBar, int avance, Corredor corredor)
        {
            if (!this._hayGanador)
            {
                if (progressBar.Value + avance < 100)
                    progressBar.Value += avance;
                else
                    this.HayGanador(corredor);
            }   
        }
        private void HayGanador(Corredor corredor)
        {
            this._hayGanador = true;
            try
            {
                foreach (Thread corredorActivo in this._corredoresActivos)
                    corredorActivo.Abort();

                ((Persona)corredor).Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ganadoressss.txt");
                MessageBox.Show("Ganador: " + ((Persona)corredor).ToString());
                this.LimpiarCarriles();
            }
            catch (NoSeGuardoException exception) { MessageBox.Show("Error: " + exception.Message); }

        }


        private void PersonaCorriendo(short avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallBack d = new CorrenCallBack(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (corredor.CarrilElegido == Corredor.Carril.Carril_1)
                    this.AnalizarCarrera(this.pgbCarril1, avance, corredor);
                else
                    this.AnalizarCarrera(this.pgbCarril2, avance, corredor);
            }

        }

        private void LimpiarCarriles()
        {
            this.pgbCarril1.Value = 0;
            this.pgbCarril2.Value = 0;
        }
        private void lblWachin1_Load(object sender, EventArgs e)
        {
            try
            {
                this._corredores = new List<Persona>();
                this._corredoresActivos = new List<Thread>();
                this._corredores.Add(new Persona(9, Corredor.Carril.Carril_1, "Fernando"));
                this._corredores.Add(new Persona(8, Corredor.Carril.Carril_2, "Fernando"));
                this._hayGanador = false;
                this._corredores[0].Corriendo += this.PersonaCorriendo;
                this._corredores[1].Corriendo += this.PersonaCorriendo;
            }
            catch (Exception exception)
            {
                this.btnCorranMierdas.Enabled = false;
                MessageBox.Show(exception.Message);
            }
        }

        private void btnCorranMierdas_Click(object sender, EventArgs e)
        {
            this._hayGanador = false;
            foreach (Corredor corredor in this._corredores)
            {
                Thread corredorActivo = new Thread(corredor.Correr);
                corredorActivo.Start();
                this._corredoresActivos.Add(corredorActivo);
            }
        }
    }
}
