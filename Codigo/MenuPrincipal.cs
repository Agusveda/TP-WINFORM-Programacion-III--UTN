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
using Funcionalidades;
using Clases;
namespace TP_WINFORM_PROGRAM3_
{
    public partial class MenuPrincipal : Form
    {
        private List<Articulo> ListaArticulos;

        public MenuPrincipal()
        {
            InitializeComponent();

        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            RepositorioArticulo repoArticulo = new RepositorioArticulo();

            try
            {

                ListaArticulos = repoArticulo.Listar(); // seteo lista
                dgvarticulos.DataSource = ListaArticulos; //agrego al dgv la lista para que se pueda visualizar



                
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
