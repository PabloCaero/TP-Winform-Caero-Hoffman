using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_Hoffman_Caero
{
    class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = comando.CommandText = "Select Id, Codigo, Nombre, Descripcion, ImagenUrl From ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDArticulo = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //aux.IDMarca = lector.GetInt32(4);
                    //aux.IDCategoria = lector.GetInt32(5);
                    aux.ImagenURL = (string)lector["ImagenURL"];
                    //aux.Precio = lector.GetFloat(7);

                    lista.Add(aux);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}