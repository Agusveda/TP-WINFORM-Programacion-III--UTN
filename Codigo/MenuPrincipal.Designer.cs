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
            this.bBorrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.bQuitar = new System.Windows.Forms.Button();
            this.btAplicar = new System.Windows.Forms.Button();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.bDetalle = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.Button();
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
            this.dgvarticulos.Location = new System.Drawing.Point(18, 106);
            this.dgvarticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.RowHeadersWidth = 51;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(944, 412);
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
            this.bAgregar.Location = new System.Drawing.Point(18, 544);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(263, 64);
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
            this.btnModificar.Location = new System.Drawing.Point(290, 544);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(251, 64);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.bBorrar.Cursor = System.Windows.Forms.Cursors.No;
            this.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBorrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.ForeColor = System.Drawing.Color.Black;
            this.bBorrar.Location = new System.Drawing.Point(565, 546);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(237, 63);
            this.bBorrar.TabIndex = 13;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(133, 63);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(320, 26);
            this.txtFiltro.TabIndex = 17;
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bQuitar.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitar.Location = new System.Drawing.Point(550, 62);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(62, 29);
            this.bQuitar.TabIndex = 18;
            this.bQuitar.Text = "Limpiar";
            this.bQuitar.UseVisualStyleBackColor = false;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // btAplicar
            // 
            this.btAplicar.BackColor = System.Drawing.Color.PaleGreen;
            this.btAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAplicar.Location = new System.Drawing.Point(465, 62);
            this.btAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(76, 30);
            this.btAplicar.TabIndex = 19;
            this.btAplicar.Text = "&Buscar";
            this.btAplicar.UseVisualStyleBackColor = false;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(15, 65);
            this.lbBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(107, 18);
            this.lbBusqueda.TabIndex = 20;
            this.lbBusqueda.Text = "Filtro Rapido:";
            // 
            // bDetalle
            // 
            this.bDetalle.BackColor = System.Drawing.Color.PaleGreen;
            this.bDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDetalle.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetalle.Location = new System.Drawing.Point(903, 546);
            this.bDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.Size = new System.Drawing.Size(58, 64);
            this.bDetalle.TabIndex = 25;
            this.bDetalle.Text = "Ver detalle";
            this.bDetalle.UseVisualStyleBackColor = false;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(998, 106);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(426, 412);
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
            this.btcerrar.Location = new System.Drawing.Point(1187, 544);
            this.btcerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(237, 63);
            this.btcerrar.TabIndex = 27;
            this.btcerrar.Text = "&Cerrar";
            this.btcerrar.UseVisualStyleBackColor = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1593, 623);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.btAplicar);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1611, 670);
            this.MinimumSize = new System.Drawing.Size(1611, 670);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Button bDetalle;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btcerrar;
    }
}

