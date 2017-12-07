using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Clase_SQL
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=.\\DEM-PC;Initial Catalog=correo-sp-2017;Integrated Security=True";
            
            SqlConnection sqlConnection = new SqlConnection(connectionStr);

            SqlCommand comando = new SqlCommand("Select * from Paquetes", sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader;
                sqlDataReader = comando.ExecuteReader();
                while (sqlDataReader.Read())
                    this.comboBox1.Items.Add(sqlDataReader["direccionEntrega"]);
                sqlConnection.Close();
            }
            catch
            {

            }

        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(Pepe);
            thread.Start();
        }
        public void Pepe()
        {
            int pspe = 2;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionStr5 = "Data Source=.\\sqlexpress;Initial Catalog=Argentina;Integrated Security=True";
            string consulta = "select * from Localidad  L inner join Provincia P on P.id = L.idProvincia where p.descripcion = '" + this.comboBox1.Text + "'";
            SqlConnection sqlConnection2 = new SqlConnection(connectionStr5);
            SqlCommand comando2 = new SqlCommand(consulta, sqlConnection2);            
            try
            {
                sqlConnection2.Open();
                SqlDataReader sqlDataReader;
                sqlDataReader = comando2.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["Nombre"]);
                }                
            }
            catch
            {

            }
            finally
            {
                sqlConnection2.Close();
            }
        }
    }
}
