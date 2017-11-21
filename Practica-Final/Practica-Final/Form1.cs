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

namespace Practica_Final
{
    public partial class Form1 : Form
    {
        private MGeneral _medicoGeneral;
        private MEspecialista _medicoEspecialista;
        private Thread _mocker;
        private Queue<Paciente> _pacientesEnespera;

        public Form1()
        {
            InitializeComponent();
            this._medicoGeneral = new MGeneral("Luis", "Salinas");
            this._medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._medicoEspecialista.AtencionFinalizada += FinAtencion;
            this._medicoGeneral.AtencionFinalizada += FinAtencion;            
            this._mocker = new Thread(this.MockPacientes);
            this._mocker.Start();
        }

        //MockPacientes() dónde se agreguen pacientes a la cola pacientesEnEspera, 
        //haciendo un Sleep de 5000 (Thread.Sleep(5000)).
        private void MockPacientes()
        {
            _pacientesEnespera = new Queue<Paciente>();
            Paciente paciente = new Paciente("Nombre1", "Apellido1");
            this._pacientesEnespera.Enqueue(paciente);
            paciente = new Paciente("Nombre2", "Apellido3", 5);
            this._pacientesEnespera.Enqueue(paciente);
            paciente = new Paciente("Nombre3", "Apellido3");
            this._pacientesEnespera.Enqueue(paciente);
            Thread.Sleep(5000);
        }

        //AtenderPacientes(IMedico) será invocado por los eventos click de los 
        //botones(btnEspecialista_Click y btnGeneral_Click) pasandole el médico que
        //corresponda(medicoEspecialista o medicoGeneral, respectivamente). En el caso de 
        //haber pacientes en espera, se deberá iniciar la atención del primer elemento de 
        //la cola.
        private void AtenderPacientes(IMedico iMedico)
        {
            if (this._pacientesEnespera.Count > 0)
                iMedico.IniciarAtencion(this._pacientesEnespera.Dequeue());
        }

        private void btnMedicoGeneral_Click(object sender, EventArgs e)
        {            
            AtenderPacientes(this._medicoGeneral);
        }


        private void btnMedicoEspecialista_Click(object sender, EventArgs e)
        {
            AtenderPacientes(this._medicoEspecialista);
            
        }

        //mostrará por medio de un , dónde se indicará el nombre del paciente y el del 
        //médico que lo atendió, respectivamente.
        private void FinAtencion(Paciente paciente, Medico medico)
        {
            MessageBox.Show(String.Format("Finalizó la atención de {0} por {1}!", paciente.ToString(), medico.ToString()));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._mocker.Abort();
        }

    }
}
