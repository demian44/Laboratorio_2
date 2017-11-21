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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Persona> _corredores;
        private List<Thread> _corredoresActivos;
        private bool _hayGanador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._corredores = new List<Persona>();
            this._corredoresActivos = new List<Thread>();         

            try
            {
                this._corredores.Add(new Persona("Fernando", 9, Carril.Carril1));
                this._corredores.Add(new Persona("Fernandote", 18, Carril.Carril2));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                this.button1.Enabled = false;
            }
            
            
            this._hayGanador = false;

        }

        private void LimpiarCarriles()
        {
            this.progressBar1.Value = 0;
            this.progressBar2.Value = 0;
        }

        private void HayGanador(Corredor corredor)
        {
            Abortar();
            MessageBox.Show("Ganador: " + ((Persona)corredor).ToString());
            ((Persona)corredor).Guardar("Ganadores.txt");
            this._hayGanador = true;
            LimpiarCarriles();
            foreach (Thread corredore in this._corredoresActivos)
            {
                corredore.Abort();
            }
        }

        delegate void CorrenCallback(int avance, Corredor corredor);

        private void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (progressBar1.InvokeRequired || progressBar2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (corredor.CarrilElegido == Carril.Carril1)
                {
                    this.AnalizarCarrera(this.progressBar1, avance, corredor);
                }
                else if (corredor.CarrilElegido == Carril.Carril2)
                {
                    this.AnalizarCarrera(this.progressBar2, avance, corredor);
                }
            }
        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {            
            if (carril.Value + avance < 100)
            {
                carril.Value += avance;
            }
            else
            {
                this.HayGanador(corredor);
                corredor.Guardar("Ganadores.txt");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Persona corredore in this._corredores)
            {
                corredore.Corriendo += PersonaCorriendo;
                Thread hilo =new Thread(corredore.Correr);
                hilo.Start();
                this._corredoresActivos.Add(hilo);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Abortar();
        }

        public void Abortar()
        {
            foreach (Thread corredor in this._corredoresActivos)
            {
                corredor.Abort();
            }
        }
    }
}
