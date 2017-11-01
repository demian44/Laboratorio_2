using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////60. En un nuevo proyecto de Windows Form:
////a. Crear una tabla en una base de datos llamada Persona con los campos:
////i. ID, autoincremental y entero.
////ii. Nombre, varchar(50).
////iii. Apellido, varchar(50).
////b. Crear una clase Persona con nombre y apellido como atributos privados.
////c. Crear un constructor que reciba ambos parámetros.
////d. Crear una clase llamada PersonaDAO y agregarle 5 métodos:
////i. Guardar: guardará una nueva persona en la base de datos.
////ii. Leer: retornará la lista de personas de la base de datos.
////iii. LeerPorID: traerá una persona, filtrando por ID.
////iv. Modificar: modificará una persona a partir de su ID.
////v. Borrar: eliminará una persona de la base de datos a partir de su ID.
////e. Armar un formulario con dos TextBox (txtNombre y txtApellido), un ListBox (lstPersonas) y 4
////botones (btnGuardar, btnModificar, btnEliminar y btnLeer).
////i. ListBox mostrará la lista de Personas devuelta por el método Leer de Persona,
////invocado al presionar el botón btnLeer.
////ii. btnModificar actualizará la información de la Persona que se seleccionó con doble
////click en el ListBox.
////iii. Al hacer doble click sobre una persona, esta se deberá cargar en los TextBox.
////iv. btnGuardar agregará una Persona en la base de datos.
////v. btnEliminar borrará de la base a la persona seleccionada en el ListBox.
namespace Ejercicio_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona;
            if (this.textBoxApellido.Text != String.Empty && this.textBoxNombre.Text != String.Empty)
            {
                persona = new Persona(this.textBoxNombre.Text, this.textBoxApellido.Text);
                PersonaDAO personaDAO = new PersonaDAO();
                personaDAO.Guardar(persona);

            }


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            PersonaDAO personaDAO = new PersonaDAO();
            List<Persona> listaPersona = personaDAO.Leer();
            if (listaPersona.Count > 0)
                foreach (Persona persona in listaPersona)
                    this.listBoxPersonas.Items.Add(String.Format("{0}-{1}-{3}", persona.ID, persona.Nombre, persona.Apellido));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != String.Empty && textBoxApellido.Text != String.Empty)
            {
                Persona persona = new Persona(int.Parse(((listBoxPersonas.SelectedItem.ToString()).Split('-'))[0]), textBoxNombre.Text, textBoxApellido.Text);
                String pepe = listBoxPersonas.SelectedItem.ToString();
                PersonaDAO personaDAO = new PersonaDAO();
                personaDAO.Modificar(new Persona(1, "ASdasd", "asdas"));
            }

        }

    }
}
