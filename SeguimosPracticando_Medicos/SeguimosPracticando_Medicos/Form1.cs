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

namespace SeguimosPracticando_Medicos
{
    public partial class Form1 : Form
    {
        private MeEspecialista medicoEspecialista;
        private MeGeneral medicoGeneral;
        private Thread mocker;
        Queue<Paciente> pacientesEnEspera;

        public Form1()
        {
            InitializeComponent();
            this.pacientesEnEspera = new Queue<Paciente>();
            this.medicoGeneral = new MeGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MeEspecialista("Jorge", "Iglesias", Especialidad.Traumatologo);
            this.medicoGeneral.AtencionFinalizada += this.FinAtencion;
            this.medicoEspecialista.AtencionFinalizada += this.FinAtencion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mocker = new Thread(MockPacientes);
            this.mocker.Start();
        }

        //        MockPacientes() dónde se agreguen pacientes a la cola
        //pacientesEnEspera, haciendo un Sleep de 5000(Thread.Sleep(5000)).
        private void MockPacientes()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(5000);
                this.pacientesEnEspera.Enqueue(new Paciente("Nombre", "Apellido"));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtenderPacientes(this.medicoGeneral);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AtenderPacientes(this.medicoEspecialista);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mocker.Abort();
        }

        private void AtenderPacientes(IMedico medico)
        {
            if (this.pacientesEnEspera.Count > 0)
            {
                if (medico is MeEspecialista)
                    this.medicoEspecialista.IniciarAtencion(this.pacientesEnEspera.Dequeue());
                else
                    this.medicoGeneral.IniciarAtencion(this.pacientesEnEspera.Dequeue());
            }
            else
            {
                MessageBox.Show("No hay pacientes");
            }

        }

        //FinAtencion(Paciente, Medico) mostrará por medio de un MessageBox un mensaje con el formato
        //, dónde se indicará el nombre del paciente y el del médico
        //que lo atendió, respectivamente.        private void FinAtencion(Paciente paciente, Medico medico)
        {
            MessageBox.Show(String.Format("Finalizó la atención de {0} por {1}!", medico.EstaAtendiendoA, medico.ToString()));
        }

    }
}
