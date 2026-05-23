using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string cadena =
            "Server=IX-AJ\\SQLEXPRESS;" +
            "Database=PuntoVentaDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion =
                new SqlConnection(cadena);

            return conexion;
        }
    }
}
