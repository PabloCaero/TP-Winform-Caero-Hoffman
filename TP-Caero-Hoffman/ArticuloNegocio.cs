using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //LIBRERIA PARA BASE DE DATOS

namespace TP_Caero_Hoffman
{
    class ArticuloNegocio
    {
        //PUBLIC: PUEDE SER ACCEDIDA DESDE EL EXTERIOR
        public List<Articulo> listar() //METODO PARA LISTAR LOS ARTICULOS
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection(); //OBJETO PARA CONECTAR A ALGO
            SqlCommand comando = new SqlCommand(); //PARA REALIZAR ACCIONES
            SqlDataReader lector; //RESULTADO EN LA LECTURA

            //HAY QUE CREAR LAS COSAS PARA ESTABLECER LA CONEXION A DB
            //MANEJO DE EXCEPCIONES

            try
            {
                //SE CONFIGURAN TODOS LOS OBJETOS CREADOS
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true";
                //ACA PONGO TODA LA FUNCIONALIDAD QUE PUEDE FALLAR (DB, ETC)
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
            return lista;

        }
    }
}
