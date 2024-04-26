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
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
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
                pbArticulo.Load(ListaArticulos[0].IdImagenUrl.ImagenURL);
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

        
        
       

        private void bAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
            CargarListado();
        }

       

        

        private void bDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvarticulos.SelectedRows.Count > 0)
                {  
                    string codigo = dgvarticulos.SelectedRows[0].Cells[1].Value.ToString();
                    string nombre = dgvarticulos.SelectedRows[0].Cells[2].Value.ToString();
                    string descripcion = dgvarticulos.SelectedRows[0].Cells[3].Value.ToString();
                    string marca = dgvarticulos.SelectedRows[0].Cells[4].Value.ToString();
                    string categoria = dgvarticulos.SelectedRows[0].Cells[5].Value.ToString();
                    string precio = dgvarticulos.SelectedRows[0].Cells[6].Value.ToString();                
                    Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                    string url = seleccion.IdImagenUrl.ImagenURL;
                    Detalle frmdetalle = new Detalle(codigo, nombre, descripcion, marca, categoria, precio,url);
                    frmdetalle.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila antes de ver el detalle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, seleccione otra fila"); ;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            CargarListado();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbArticulo.Load("https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png");

            }
        }
        private void dgvarticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvarticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.IdImagenUrl.ImagenURL);
            }

        }
    }
}
