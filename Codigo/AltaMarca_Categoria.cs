using Clases;
using Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WINFORM_PROGRAM3_
{
    public partial class AltaMarca_Categoria : Form
    {
        bool parametro = true;
        public AltaMarca_Categoria() //cuando sea marca
        {
            InitializeComponent();
            txtCat.ReadOnly = true;
        }
        public AltaMarca_Categoria(bool parametro) //cuando sea categoria
        {
            InitializeComponent();
            this.parametro = parametro;
            txtMarca.ReadOnly = true;


        }


        private void AltaMarca_Categoria_Load(object sender, EventArgs e)
        {
            RepositorioMarca repoMarca = new RepositorioMarca();

            cbMarca.DataSource = repoMarca.Listar(); // seteo desplegable marca
            cbMarca.ValueMember = "ID";
            cbMarca.DisplayMember = "Descripcion";


            RepositorioCategoria repoCategoria = new RepositorioCategoria();

            cbCat.DataSource = repoCategoria.Listar(); // seteo desplegable categoria
            cbCat.ValueMember = "ID";
            cbCat.DisplayMember = "Descripcion";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (parametro == false)
            {
                if (txtCat.Text == "")

                {
                    MessageBox.Show("Campo vacio, porfavor rellenarlo correctamente...");
                }
                else
                {

                    RepositorioCategoria repoCat = new RepositorioCategoria();
                    try
                    {
                        Categoria auxcat = new Categoria();

                        auxcat.Descripcion = txtCat.Text;
                        repoCat.Agregar(auxcat);

                        MessageBox.Show("Agregado exitosamente...");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    finally { Close(); }
                }

            }
            if (parametro == true)
            {


                if (txtMarca.Text == "")
                {
                    MessageBox.Show("Campo vacio, porfavor rellenarlo correctamente...");
                }

                else
                {

                    RepositorioMarca repoMarca = new RepositorioMarca();
                    try
                    {
                        Marca auxMarca = new Marca();

                        auxMarca.Descripcion = txtMarca.Text;
                        repoMarca.Agregar(auxMarca);

                        MessageBox.Show("Agregado exitosamente...");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    finally { Close(); }

                }



            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

            
        
    



    

