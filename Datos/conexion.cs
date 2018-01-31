using System.Collections.Generic;
using Npgsql;


namespace Datos
{
    public class ClsConexion
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            int clave = 123;
            string baseDatos = "estudiantes";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public void InsertarDatos(int cedula, string nombre, int edad, string comentario)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO estudiante (cedula, nombre, edad, comentario) VALUES ('" + cedula + "', '" + nombre + "', '" + edad + "', '" + comentario + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<int> ComboBox()
        {
            Conexion();
            conexion.Open();
            List<int> lista = new List<int>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT cedula FROM estudiantes;", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetInt32(0));
                }
            }
            conexion.Close();

            return lista;
        }

        public List<object> Informacion(int cedula)
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM estudiantes WHERE cedula = " + cedula + " ;", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetInt32(0));
                    lista.Add(dr.GetString(1));
                    lista.Add(dr.GetDate(2));
                    lista.Add(dr.GetString(3));
                }
            }
            conexion.Close();

            return lista;
        }
    }
}
