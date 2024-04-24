using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            RepositorioArticulo repoart = new RepositorioArticulo();
           try 
            {
            Articulo auxArt = new Articulo();
                auxArt.Codigo = txtCodigo.Text;
                auxArt.Nombre = txtNombre.Text;
                auxArt.descripcion = txtDescripcion.Text;
                auxArt.idCategoria= (Categoria)cboCategoria.SelectedItem;
                auxArt.idMarca = (Marca)CboMarca.SelectedItem;
                auxArt.Precio = decimal.Parse(txtPrecio.Text);

                repoart.Agregar(auxArt);
                MessageBox.Show("agregado exitosamente");
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

            RepositorioCategoria repoCategoria = new RepositorioCategoria();

            cboCategoria.DataSource = repoCategoria.Listar(); // seteo desplegable categoria
            cboCategoria.ValueMember = "ID";
            cboCategoria.DisplayMember = "Descripcion";

        }

        //private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        //{}
        //Ctrl+K+C
    }
}
