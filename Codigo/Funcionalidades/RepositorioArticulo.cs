using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Funcionalidades;


namespace Funcionalidades
{
    public class RepositorioArticulo
    {
        public List<Articulo> Listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            Conexion_Comandos AccesoDatos = new Conexion_Comandos();
            try {
            AccesoDatos.setearConsulta("select a.Id,A.Codigo, A.Nombre,A.Descripcion,A.Precio,m.Id as IdMarca ,M.Descripcion AS DescripcionMarca, c.Id as Idcategoria,C.Descripcion AS DescripcionCate,i.Id as IdImg, I.ImagenUrl from ARTICULOS A inner join MARCAS M on M.Id = A.IdMarca inner join CATEGORIAS C on C.Id = A.IdCategoria inner join IMAGENES I on I.IdArticulo = A.Id");
            AccesoDatos.ejecutarLectura();

            while(AccesoDatos.Lector.Read())
                {
                        Articulo aux = new Articulo();



                    aux.id = (int)AccesoDatos.Lector["Id"];
                    aux.Codigo = (string)AccesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)AccesoDatos.Lector["Nombre"];
                    aux.descipcion= (string)AccesoDatos.Lector["Descripcion"];
                    aux.Precio = (decimal)AccesoDatos.Lector["Precio"];


                    //Creamos un aux marca para poder cargar las columnas
                    
                    aux.idMarca = new Marca();
                    aux.idMarca.Id = (int)AccesoDatos.Lector["IdMarca"];
                    aux.idMarca.Descripcion = (string)AccesoDatos.Lector["DescripcionMarca"];

                    //Creamos un aux categoria para poder cargar las columnas

                    aux.idCategoria = new Categoria();
                    aux.idCategoria.Id = (int)AccesoDatos.Lector["Idcategoria"];
                    aux.idCategoria.Descripcion = (string)AccesoDatos.Lector["DescripcionCate"];
                   


                    listaArticulo.Add(aux);

                }

                AccesoDatos.cerrarConexion();

                return listaArticulo;


            } 
            
            catch (Exception ex)
            {
                throw ex;

            }
          



        }


    }
}
