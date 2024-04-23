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
        private List<Articulo> ListaMarcas;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                
                RepositorioArticulo repoArticulo = new RepositorioArticulo();
                ListaMarcas = repoArticulo.Listar(); // seteo lista
                for (int i = 0; i < ListaMarcas.Count;i++)
                {
                    CboMarca = ListaMarcas[i]; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo aux = new Articulo();
            RepositorioArticulo repoArticulo = new RepositorioArticulo();
           try 
            {
                aux.Codigo = (string)txtCodigo.Text;
                aux.Nombre = (string)txtNombre.Text;
                aux.Descripcion = (string)txtDescripcion.Text;
                aux.Precio = int.Parse(txtPrecio.Text);
                aux.idMarca = new Marca();
                aux.idMarca.Id = int.Parse(CboMarca.Text);
                aux.idCategoria = new Categoria();
                aux.idCategoria.Id = int.Parse(txtCategoria.Text);
                aux.IdImagenUrl = new Imagenes();
                aux.IdImagenUrl.ImagenURL = (string)txtImagenUrl.Text;
                repoArticulo.agregar(aux);
                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
