using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    //    A.De surgir cualquier error con la carga de datos, se deberá lanzar 
    //una excepción y controlarla en el método que la haya llamado, sin 
    //realizar ninguna acción con esta.B.El campo alumno de la base de datos 
    //deberá contener el nombre del alumno que está realizando el examen.

    public static class PaqueteDAO
    {
        static string connectionStr;
        static SqlConnection sqlConnection;

        public static bool Insertar(Paquete paquete)
        {
            bool retorno = false;
            string query = string.Format("Insert into Paquetes(direccionEntrega,trackingID,alumno) values ('{0}','{1}','{2}')", paquete.DireccionEntrega, paquete.TrackingID, "Demian Alejandro Boullon bitches");
            SqlCommand comando = new SqlCommand(query, sqlConnection);
            

                try
                {
                    sqlConnection.Open();
                    comando.ExecuteNonQuery();
                    retorno = true;
                }
                catch (Exception exception) { }
                finally { sqlConnection.Close(); }
            return retorno;
            
        }

        static PaqueteDAO()
        {
            connectionStr = "Data Source=.;Initial Catalog=correo-sp-2017;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionStr);
        }
    }

}
