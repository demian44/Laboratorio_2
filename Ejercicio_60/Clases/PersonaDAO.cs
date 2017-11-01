using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PersonaDAO
    {
        public int Guardar(Persona persona)
        {
            int succes = 0;
            SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Persona;Integrated Security=True");
            SqlCommand comando = new SqlCommand("INsert into Persona(nombre,apellido) values('" + persona.Nombre + "','" + persona.Apellido + "')", sqlConnection);
            try
            {
                sqlConnection.Open();
                succes = comando.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                sqlConnection.Close();
            }
            return succes;
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();
            SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Persona;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT *  FROM Persona", sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    listaPersonas.Add(new Persona(int.Parse(sqlDataReader["id"].ToString()), sqlDataReader["nombre"].ToString(), sqlDataReader["apellido"].ToString()));
                }

            }
            catch (SqlException exception)
            {
            }
            catch (Exception exceptions)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return listaPersonas;
        }

        //LeerPorID: traerá una persona, filtrando por ID.
        public Persona LeerPorID(int id)
        {
            Persona persona = null;
            SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Persona;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT *  FROM Persona where id = " + id.ToString(), sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                persona = new Persona(int.Parse(sqlDataReader["id"].ToString()),sqlDataReader["nombre"].ToString(), sqlDataReader["apellido"].ToString());

            }
            catch (SqlException exception)
            {
            }
            catch (Exception exceptions)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return persona;
        }

        //iv. Modificar: modificará una persona a partir de su ID.
        public int Modificar(Persona persona)
        {
            {
                int succes = 0;
                SqlConnection sqlConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Persona;Integrated Security=True");
                SqlCommand comando = new SqlCommand("Update Persona(nombre,apellido) values('" + persona.Nombre + "','" + persona.Apellido + "') where id = " + persona.ID.ToString(), sqlConnection);
                try
                {
                    sqlConnection.Open();
                    succes = comando.ExecuteNonQuery();
                }
                catch { }
                finally
                {
                    sqlConnection.Close();
                }
                return succes;
            }
        }

        //v. Borrar: eliminará una persona de la base de datos a partir de su ID
        public void Borrar(int id)
        {

        }

        private void EjecutarComando()
        {


        }
    }
}
