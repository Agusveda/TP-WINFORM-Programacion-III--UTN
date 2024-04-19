using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Funcionalidades
{
    public class Conexion_Comandos
    {

        SqlConnection conexion;
        SqlCommand comando; 
        SqlDataReader lector;
        public SqlDataReader Lector { get { return lector; } }
        public Conexion_Comandos()
        {
            conexion = new SqlConnection("server= DESKTOP-DLD9B46; database=CATALOGO_P3_DB; Integrated Security = True");
            //  conexion = new SqlConnection("server= FACU; database=CATALOGO_P3_DB; Integrated Security = True");
            // conexion = new SqlConnection("server= DESKTOP-A3HCDG7; database=CATALOGO_P3_DB; Integrated Security = True");

            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }















    }
}
