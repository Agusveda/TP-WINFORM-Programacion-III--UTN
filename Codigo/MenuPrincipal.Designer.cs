namespace TP_WINFORM_PROGRAM3_
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.PbImagen = new System.Windows.Forms.PictureBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bAplicar = new System.Windows.Forms.Button();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(347, 108);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(420, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(347, 82);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(43, 13);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(420, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(420, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(347, 134);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 6;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(347, 160);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 13);
            this.lbMarca.TabIndex = 7;
            this.lbMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(420, 157);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(347, 186);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbCategoria.TabIndex = 9;
            this.lbCategoria.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(420, 183);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 10;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(350, 386);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 11;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(445, 386);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 12;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.Transparent;
            this.bBorrar.ForeColor = System.Drawing.Color.Red;
            this.bBorrar.Location = new System.Drawing.Point(707, 386);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 13;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            // 
            // PbImagen
            // 
            this.PbImagen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PbImagen.Location = new System.Drawing.Point(648, 79);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(134, 124);
            this.PbImagen.TabIndex = 14;
            this.PbImagen.TabStop = false;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(597, 79);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(45, 13);
            this.lbImagen.TabIndex = 15;
            this.lbImagen.Text = "Imagen:";
            // 
            // textFiltro
            // 
            this.textFiltro.Location = new System.Drawing.Point(420, 41);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(222, 20);
            this.textFiltro.TabIndex = 17;
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(648, 41);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 20);
            this.bQuitar.TabIndex = 18;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            // 
            // bAplicar
            // 
            this.bAplicar.Location = new System.Drawing.Point(344, 41);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(70, 20);
            this.bAplicar.TabIndex = 19;
            this.bAplicar.Text = "Aplicar";
            this.bAplicar.UseVisualStyleBackColor = true;
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(484, 25);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(95, 13);
            this.lbBusqueda.TabIndex = 20;
            this.lbBusqueda.Text = "Busqueda por filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Listado de articulos";
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.Location = new System.Drawing.Point(40, 84);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.Size = new System.Drawing.Size(274, 276);
            this.dgvarticulos.TabIndex = 22;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.bAplicar);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.textFiltro);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.PbImagen);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.PictureBox PbImagen;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvarticulos;
    }
}

