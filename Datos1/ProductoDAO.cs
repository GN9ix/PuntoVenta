using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PuntoVenta.Modelos;

namespace Datos
{
    public class ProductoDAO
    {
        Conexion cn = new Conexion();

        public void InsertarProducto(Producto producto)
        {
            using (SqlConnection conexion =
                cn.ObtenerConexion())
            {
                string query =
                    @"INSERT INTO Productos
                    (
                        Nombre,
                        CodigoBarras,
                        PrecioCompra,
                        PrecioVenta,
                        Stock,
                        Lote,
                        FechaVencimiento
                    )
                    VALUES
                    (
                        @nombre,
                        @codigo,
                        @compra,
                        @venta,
                        @stock,
                        @lote,
                        @fecha
                    )";

                SqlCommand cmd =
                    new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue(
                    "@nombre",
                    producto.Nombre);

                cmd.Parameters.AddWithValue(
                    "@codigo",
                    producto.CodigoBarras);

                cmd.Parameters.AddWithValue(
                    "@compra",
                    producto.PrecioCompra);

                cmd.Parameters.AddWithValue(
                    "@venta",
                    producto.PrecioVenta);

                cmd.Parameters.AddWithValue(
                    "@stock",
                    producto.Stock);

                cmd.Parameters.AddWithValue(
                    "@lote",
                    producto.Lote);

                cmd.Parameters.AddWithValue(
                    "@fecha",
                    producto.FechaExpiracion);

                conexion.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> lista =
                new List<Producto>();

            using (SqlConnection conexion =
                cn.ObtenerConexion())
            {
                string query =
                    "SELECT * FROM Productos";

                SqlCommand cmd =
                    new SqlCommand(query, conexion);

                conexion.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto =
                        new Producto()
                        {
                            Id = Convert.ToInt32(reader["Id"]),

                            Nombre = reader["Nombre"].ToString(),

                            CodigoBarras = reader["CodigoBarras"].ToString(),

                            PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),

                            PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),

                            Stock = Convert.ToInt32(reader["Stock"]),

                            Lote = reader["Lote"].ToString(),

                            FechaExpiracion = Convert.ToDateTime(reader["FechaVencimiento"])
                        };

                    lista.Add(producto);
                }
            }

            return lista;
        }
    }
}
