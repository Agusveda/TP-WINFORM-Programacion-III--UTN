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
            

            try
            {


                RepositorioArticulo repoArticulo = new RepositorioArticulo();
                ListaArticulos = repoArticulo.Listar(); // seteo lista
                dgvarticulos.DataSource = ListaArticulos; //agrego al dgv la lista para que se pueda visualizar
                PbArticulo.Load(ListaArticulos[0].IdImagenUrl.ImagenURL);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColumnas()
        {
            dgvarticulos.Columns["ImagenUrl"].Visible = false;
            dgvarticulos.Columns["id"].Visible = false;
        } // oculto columnas del dgv

        private void dgvarticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvarticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.IdImagenUrl.ImagenURL);
            }
            
        }
        
        private void cargarImagen(string imagen)
        {
            try
            {
                PbArticulo.Load(imagen);
            }
            catch (Exception)
            {

                PbArticulo.Load("https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png");

            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
            CargarListado();
        }
    }
}
