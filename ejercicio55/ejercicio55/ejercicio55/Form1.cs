using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ejercicio55
{
    public partial class formPrincipal : Form
    {
        StreamReader file = null;
        SaveFileDialog saveDia;
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openfile1 = new OpenFileDialog();
     
            if(openfile1.ShowDialog() == DialogResult.OK)
            {
                file = new StreamReader(openfile1.FileName);
                rTxt.Text = file.ReadToEnd();
                file.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveDia != null && saveDia.FileName != String.Empty)
            {
                StreamWriter saveFile = new StreamWriter(saveDia.FileName);
                saveFile.Write(rTxt.Text);
                saveFile.Close();
            }
            else 
            {
                saveDia = new SaveFileDialog();

                if (saveDia.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter saveFile = new StreamWriter(saveDia.FileName);
                    saveFile.Write(rTxt.Text);
                    saveFile.Close();
                }
            }
  
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDia = new SaveFileDialog();
 
            if(saveDia.ShowDialog() == DialogResult.OK)
            {
                StreamWriter saveFile = new StreamWriter(saveDia.FileName);
                saveFile.Write(rTxt.Text);
                saveFile.Close();
            }
             
        }
    }
}
