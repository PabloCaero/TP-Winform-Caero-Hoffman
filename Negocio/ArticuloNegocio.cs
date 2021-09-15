using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
   public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.ImagenUrl, C.Descripcion as Categoria  From ARTICULOS A, CATEGORIAS C Where A.IDCategoria = C.ID");
                datos.ejecturaLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDArticulo = datos.Lector.GetInt32(0);
                    aux.Codigo = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Descripcion = datos.Lector.GetString(3);
                    aux.IDMarca = datos.Lector.GetInt32(4);
                    aux.IDCategoria = datos.Lector.GetInt32(5);
                    aux.ImagenURL = datos.Lector.GetString(6);
                    //aux.Precio = datos.Lector.GetDouble(7);

                    //IMPORTANTE PARA COMPOSICION y PARA TRAER COSAS DE OTRAS TABLAS REGISTROS COMPUESTOS
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}