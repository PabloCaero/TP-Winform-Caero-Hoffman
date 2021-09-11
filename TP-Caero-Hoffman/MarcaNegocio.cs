﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //LIBRERIA PARA BASE DE DATOS

namespace TP_Caero_Hoffman
{
    class MarcaNegocio
    {
        //PUBLIC: PUEDE SER ACCEDIDA DESDE EL EXTERIOR
        public List<Marca> listar() //METODO PARA LISTAR LOS ARTICULOS
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection(); //OBJETO PARA CONECTAR A ALGO
            SqlCommand comando = new SqlCommand(); //PARA REALIZAR ACCIONES
            SqlDataReader lector; //RESULTADO EN LA LECTURA

            //HAY QUE CREAR LAS COSAS PARA ESTABLECER LA CONEXION A DB
            //MANEJO DE EXCEPCIONES

            try
            {
                //ACA PONGO TODA LA FUNCIONALIDAD QUE PUEDE FALLAR (DB, ETC)
                //SE CONFIGURAN TODOS LOS OBJETOS CREADOS
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                //SE CONFIGURA EL COMANDO (SE REALIZA LA LECTURA)
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion From MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IDMarca = (int)lector["Id"];/*lector.GetInt32(0);*/
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);

                }
                conexion.Close();
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
