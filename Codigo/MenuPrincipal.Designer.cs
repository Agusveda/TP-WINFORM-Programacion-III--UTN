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
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.bAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.bDetalle = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.Button();
            this.lbCampo = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBajaFisica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.AccessibleName = "";
            this.dgvarticulos.AllowUserToAddRows = false;
            this.dgvarticulos.AllowUserToDeleteRows = false;
            this.dgvarticulos.AllowUserToResizeColumns = false;
            this.dgvarticulos.AllowUserToResizeRows = false;
            this.dgvarticulos.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvarticulos.Location = new System.Drawing.Point(16, 92);
            this.dgvarticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.RowHeadersWidth = 51;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(839, 366);
            this.dgvarticulos.TabIndex = 22;
            this.dgvarticulos.SelectionChanged += new System.EventHandler(this.dgvarticulos_SelectionChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.bAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAgregar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bAgregar.Location = new System.Drawing.Point(16, 466);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(176, 54);
            this.bAgregar.TabIndex = 11;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(213, 466);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 54);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(468, 467);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(153, 53);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Baja Logica";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(115, 56);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(285, 20);
            this.txtFiltro.TabIndex = 17;
            this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(411, 53);
            this.btnLimpiarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(55, 26);
            this.btnLimpiarFiltro.TabIndex = 18;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(13, 58);
            this.lbBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(83, 13);
            this.lbBusqueda.TabIndex = 20;
            this.lbBusqueda.Text = "Filtro Rapido:";
            // 
            // bDetalle
            // 
            this.bDetalle.BackColor = System.Drawing.Color.PaleGreen;
            this.bDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDetalle.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetalle.Location = new System.Drawing.Point(396, 465);
            this.bDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.Size = new System.Drawing.Size(52, 55);
            this.bDetalle.TabIndex = 25;
            this.bDetalle.Text = "Ver detalle";
            this.bDetalle.UseVisualStyleBackColor = false;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(887, 94);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(379, 366);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticulo.TabIndex = 26;
            this.pbArticulo.TabStop = false;
            // 
            // btcerrar
            // 
            this.btcerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btcerrar.Cursor = System.Windows.Forms.Cursors.No;
            this.btcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcerrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrar.ForeColor = System.Drawing.Color.Black;
            this.btcerrar.Location = new System.Drawing.Point(1055, 484);
            this.btcerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(211, 56);
            this.btcerrar.TabIndex = 27;
            this.btcerrar.Text = "&Cerrar";
            this.btcerrar.UseVisualStyleBackColor = false;
            this.btcerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.Location = new System.Drawing.Point(28, 568);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(73, 17);
            this.lbCampo.TabIndex = 28;
            this.lbCampo.Text = "Campo : ";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(105, 569);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(106, 20);
            this.cbCampo.TabIndex = 29;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(315, 571);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(106, 20);
            this.cbCriterio.TabIndex = 31;
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.Location = new System.Drawing.Point(229, 569);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(75, 17);
            this.lbCriterio.TabIndex = 30;
            this.lbCriterio.Text = "Criterio : ";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(427, 570);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(64, 17);
            this.lbFiltro.TabIndex = 32;
            this.lbFiltro.Text = "Filtro :  ";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(489, 571);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(106, 20);
            this.txtFiltroAvanzado.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(615, 568);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBajaFisica
            // 
            this.btnBajaFisica.BackColor = System.Drawing.Color.Firebrick;
            this.btnBajaFisica.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBajaFisica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajaFisica.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFisica.ForeColor = System.Drawing.Color.Black;
            this.btnBajaFisica.Location = new System.Drawing.Point(702, 467);
            this.btnBajaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajaFisica.Name = "btnBajaFisica";
            this.btnBajaFisica.Size = new System.Drawing.Size(153, 53);
            this.btnBajaFisica.TabIndex = 35;
            this.btnBajaFisica.Text = "BajaFisica";
            this.btnBajaFisica.UseVisualStyleBackColor = false;
            this.btnBajaFisica.Click += new System.EventHandler(this.btnBajaFisica_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1364, 632);
            this.Controls.Add(this.btnBajaFisica);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lbCampo);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Button bDetalle;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btcerrar;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBajaFisica;
    }
}

