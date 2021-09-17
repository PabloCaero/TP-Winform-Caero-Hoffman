﻿using System;
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
        private const string V = "')";

        public List<Articulo>listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Codigo,A.nombre,A.descripcion,A.imagenurl,A.Precio, C.descripcion Categoria, M.descripcion Marca  from ARTICULOS A , CATEGORIAS C, MARCAS M  WHERE C.Id= A.IdCategoria and M.id = A.idMarca");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenURL = (string)datos.Lector["ImagenURL"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    //IMPORTANTE PARA COMPOSICION y PARA TRAER COSAS DE OTRAS TABLAS REGISTROS COMPUESTOS
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo,Nombre, Descripcion , ImagenURL, IDMarca, IDCategoria, Precio) values ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "','" + nuevo.Descripcion + "' , '" + nuevo.ImagenURL + "', @IDMarca , @IDCategoria , @Precio)");
                datos.setearParametros("@IDMarca", nuevo.Marca.IDMarca);
                datos.setearParametros("@IDCategoria", nuevo.Categoria.IDCategoria);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> buscarCodigo(Articulo buscar)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Codigo, A.Nombre, Cast(A.Precio as Decimal(10, 2)) as Precio, A.ImagenURL, M.Descripcion as Marca from ARTICULOS A , MARCAS M  WHERE M.Id= A.IdMarca and A.Codigo = '" + buscar.Codigo + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenURL = (string)datos.Lector["ImagenURL"];

                    //IMPORTANTE PARA COMPOSICION y PARA TRAER COSAS DE OTRAS TABLAS REGISTROS COMPUESTOS

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


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

        public List<Articulo> buscarNombre(Articulo buscar)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Codigo, A.Nombre, Cast(A.Precio as Decimal(10, 2)) as Precio, A.ImagenURL, M.Descripcion as Marca from ARTICULOS A , MARCAS M  WHERE M.Id= A.IdMarca and A.Nombre= '" + buscar.Nombre + "'");
                datos.ejecturaLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenURL = (string)datos.Lector["ImagenURL"];

                    //IMPORTANTE PARA COMPOSICION y PARA TRAER COSAS DE OTRAS TABLAS REGISTROS COMPUESTOS

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
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
