using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDAO
    {
        Conexion cn = new Conexion();

        public void InsertarUsuario(string usuario, string password)
        {
            SqlConnection conexion = cn.ObtenerConexion();

            string query =
                "INSERT INTO Usuarios (Usuario, Password) " +
                "VALUES (@usuario, @password)";

            SqlCommand cmd =
                new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@password", password);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public bool ValidarUsuario(string usuario, string pass)
        {
            bool valido = false;

            using (SqlConnection conexion = cn.ObtenerConexion())
            {
                string query = @"SELECT COUNT(*) 
                                 FROM Usuarios
                                 WHERE Usuario = @usuario
                                 AND Password = @pass";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pass", pass);

                conexion.Open();

                int cantidad =
                    Convert.ToInt32(cmd.ExecuteScalar());

                if (cantidad > 0)
                {
                    valido = true;
                }
            }

            return valido;
        }
    }
}
