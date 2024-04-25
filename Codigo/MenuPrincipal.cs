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
    }
}
