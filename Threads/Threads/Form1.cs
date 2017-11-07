using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coso coso = new Coso { Mensaje = TextBoxCoso.Text };
            Coso coso2 = new Coso { Mensaje = "A lo hecho pecho." };
            Thread thread = new Thread(coso.ElCoso);
            thread.Start();
            MessageBox.Show("Muy claro lisa o muy oscuuuuro.");
        }
    }


    public class Coso
    {
        public string Mensaje { get; set; } 

        public void ElCoso()
        {
            
           
            int contador = 0;
            
            
            long timepo = long.Parse(DateTime.Now.Second.ToString()) + 2;
            while (true)
            {
                if(long.Parse(DateTime.Now.Second.ToString()) > timepo)
                {
                    MessageBox.Show("A lo hecho pecho.");
                    timepo += 50;
                    contador++;
                }
                if (contador > 6)
                    break;
            }
        }
    }
}
