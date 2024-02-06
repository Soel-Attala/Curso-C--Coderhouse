using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

static void main(string[] args)
{
    string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        /*
        //creamos el comando a ejecutar
        using (SqlCommand command = new SqlCommand("SELECT * FROM USERS", connection))
        {
            //abrimos la conexion
            connection.Open();

            //preguntamos si devolvio columnas
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    var dataToUse = reader.GetString(1);

                    //aqui trabajamos con el dato a usar

                }
            }

            connection.Close();

        }
        */


        //creamos el comando a ejecutar
        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM USERS", connection))
        {
            connection.Open();

            DataSet result = new DataSet(); //creamos el objeto vacio

            adapter.Fill(result); // llenamos el objeto con lo que nos devuelve la db

            connection.Close(); //cerramos conexion
        }

    }
}
