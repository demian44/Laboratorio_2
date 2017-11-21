using Entidades;
using Exceptions;
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
using static Entidades.Corredor;

namespace SeguimosPracticando_Carrera
{
    public partial class Form1 : Form
    {
        private List<Persona> _corredores;
        private new List<Thread> _corredoresActivos;
        private bool _hayGanador;

        public Form1()
        {
            InitializeComponent();
            this._corredores = new List<Persona>();
            this._corredoresActivos = new List<Thread>();
            this._corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this._corredores.Add(new Persona("Fernando", 15, Corredor.Carril.Carril_2));
            this._hayGanador = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Persona corredor in this._corredores)
                corredor.Corriendo += PersonaCorriendo;
        }

        #region Metodos
        private void HayGanador(Persona corredor)
        {
            try
            {
                foreach (Thread hilo in this._corredoresActivos)
                    hilo.Abort();
                corredor.Guardar();
                MessageBox.Show("Ganador!\n" + corredor.ToString());
                this.LimpiarCarriles();
            }
            catch (NoSeGuardoException exception) { MessageBox.Show(exception.Message); }
            catch (Exception exception) { MessageBox.Show(exception.Message); }

        }
        private void LimpiarCarriles()
        {
            this.pgbCarril2.Value = this.pgbCarril1.Value = 0;
        }

        //AnalizarCarrera analiza al competidor, suma en el ProgressBar el avance y
        //avisa si hay  ganador.        
        private void AnalizarCarrera(ProgressBar carril, short avance, Persona corredor)
        {
            if ((carril.Value + avance) < 100)
                carril.Value += avance;
            else
                this.HayGanador(corredor);
        }

        private delegate void CorrenCallback(int avance, Persona corredor);
        private void PersonaCorriendo(int avance, Persona corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (corredor.CarrilElegido == Carril.Carril_1)
                    this.AnalizarCarrera(this.pgbCarril1,(short)avance, corredor);
                else
                    this.AnalizarCarrera(this.pgbCarril2,(short)avance, corredor);
            }
        }

        #endregion

        private void btnCorran_Click(object sender, EventArgs e)
        {
            foreach(Persona corredor in this._corredores)
            {
                Thread hilo = new Thread(corredor.Correr);
                hilo.Start();
                this._corredoresActivos.Add(hilo);
            }
        }

        private void btnAtentado_Click(object sender, EventArgs e)
        {
            foreach (Thread hilo in this._corredoresActivos)
            { 
                hilo.Abort();
            }

            this.LimpiarCarriles();
        }
    }
}
