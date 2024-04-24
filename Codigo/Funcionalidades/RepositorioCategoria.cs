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
    public class RepositorioCategoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            Conexion_Comandos AccesoDatos = new Conexion_Comandos();
            try
            {
                AccesoDatos.setearConsulta("select * from CATEGORIAS");
                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)AccesoDatos.Lector["Id"];
                    aux.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    listaCategoria.Add(aux);
                }



                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { AccesoDatos.cerrarConexion(); }

        }
    }
}

