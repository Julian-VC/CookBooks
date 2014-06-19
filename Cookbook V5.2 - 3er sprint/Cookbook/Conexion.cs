using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Cookbook
{
    class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();
        public Conexion()
        {


            string cadenaConexion = "Server=localhost;Database=mydb;User id=root;Password=36901733";
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

        }


        public List<String> consulta(String consulta)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = consulta;
            cmd.Connection = conexion;

            MySqlDataReader reader = cmd.ExecuteReader();

            int cantidad = reader.FieldCount;


            List<String> resultado = new List<String>();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    for (int indice2 = 0; indice2 < cantidad; indice2++)
                    {
                        resultado.Add(reader.GetValue(indice2).ToString());
                    }


                }
            }

            reader.Close();
            /*

        for (int indice = 0; indice < cantidad*2; indice++)
        {
            if (reader.Read())
            {

                resultado.Add( reader.GetValue(indice).ToString());
            }
            else
            {

                resultado.Add( reader.GetValue(indice).ToString());
            }

        }*/

            return resultado;

        }

        public void cerrarConexion()
        {
            conexion.Close();

        }
    }
}
