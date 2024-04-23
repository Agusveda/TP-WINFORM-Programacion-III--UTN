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
    public class RepositorioMarca
    {
        public List<Marca> Listar() {
            List<Marca> listaMarca = new List<Marca>();
            Conexion_Comandos AccesoDatos = new Conexion_Comandos();
            try
			{
                AccesoDatos.setearConsulta("select * from MARCAS");
                AccesoDatos.ejecutarLectura();
                while (AccesoDatos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)AccesoDatos.Lector["Id"];
                    aux.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    listaMarca.Add(aux);
                }



				return listaMarca;
			}
			catch (Exception ex)
			{

				throw ex;
			}
            finally { AccesoDatos.cerrarConexion(); }
            
        }
    }
}
