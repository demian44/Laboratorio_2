using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void MiDelegado(string valor);

        private void Form1_Load(object sender, EventArgs e)
        {         
            frmDatos nuevoFrmDatos = new frmDatos();
            MiDelegado miDelegado = nuevoFrmDatos.ActualizarNombre;
            
            
                        
            nuevoFrmDatos.Parent = this;

            nuevoFrmDatos.Show();
        }
    }
}
