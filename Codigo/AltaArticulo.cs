using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Funcionalidades;
 

namespace TP_WINFORM_PROGRAM3_
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           try 
            {
            Articulo auxArt = new Articulo();
                //articulo.Codigo = txtCodigo.Text;
                //articulo.Nombre = txtNombre.Text;
                //articulo.descipcion = txtDescripcion.Text;
                //articulo.idMarca =  txtNombre.Text;
                //articulo.idCategoria = txtNombre.Text;
                
                auxArt.Codigo = (string)txtNombre.Text;
                auxArt.Nombre = (string)txtDescripcion.Text;
                auxArt.descipcion = (string)txtDescripcion.Text;
                auxArt.Precio = decimal.Parse(txtPrecio.Text);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            RepositorioMarca repoMarca = new RepositorioMarca();
            
            CboMarca.DataSource = repoMarca.Listar(); // seteo desplegable marca
            CboMarca.ValueMember = "ID";
            CboMarca.DisplayMember = "Descripcion";
        }
    }
}
