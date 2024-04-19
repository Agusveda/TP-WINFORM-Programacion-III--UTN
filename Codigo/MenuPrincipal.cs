using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Libreria para todo lo relacionado con la base de datos

namespace TP_WINFORM_PROGRAM3_
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        
        }

        //Linea para crear la conexion a la base de datos.
        SqlConnection conexion = new SqlConnection("server=FACU;database=CATALOGO_P3_DB;integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            //Linea para mostrar los datos de la tabla en el datagridview
            string consulta = "SELECT * FROM ARTICULOS";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView2.DataSource = tabla;
        }

        


    }
}
