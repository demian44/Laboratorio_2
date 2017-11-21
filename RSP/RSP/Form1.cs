using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSP
{
    public partial class Form1 : Form
    {
        private LosHilos _hilos;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._hilos = new LosHilos();
            this._hilos.AvisoFin += this.MostrarMensajeFin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                if (this.textBox1.Text != String.Empty)
                {
                    foreach (char caracter in this.textBox1.Text)
                    {
                        if (!char.IsNumber(caracter))
                        {
                            MessageBox.Show("Ingrese solo numeros positivos.");
                            flag = !flag;
                            break;
                        }
                    }
                }
                if (flag)
                    this._hilos += 5;
            }
            catch (CantidadInvalidaException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void MostrarMensajeFin(string mensaje)
        {

            MessageBox.Show(mensaje);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._hilos.Bitacora);
        }
    }
}
