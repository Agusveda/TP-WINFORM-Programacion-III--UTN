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
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.bDetalle = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.Button();
            this.lbCampo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.bBorrar.Cursor = System.Windows.Forms.Cursors.No;
            this.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBorrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.ForeColor = System.Drawing.Color.Black;
            this.bBorrar.Location = new System.Drawing.Point(702, 467);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(153, 53);
            this.bBorrar.TabIndex = 13;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(115, 56);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(285, 23);
            this.txtFiltro.TabIndex = 17;
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bQuitar.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitar.Location = new System.Drawing.Point(411, 53);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(55, 26);
            this.bQuitar.TabIndex = 18;
            this.bQuitar.Text = "Limpiar";
            this.bQuitar.UseVisualStyleBackColor = false;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(13, 58);
            this.lbBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(94, 16);
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
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.Location = new System.Drawing.Point(28, 568);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(89, 20);
            this.lbCampo.TabIndex = 28;
            this.lbCampo.Text = "Campo : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 569);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(315, 570);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.Location = new System.Drawing.Point(229, 569);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(92, 20);
            this.lbCriterio.TabIndex = 30;
            this.lbCriterio.Text = "Criterio : ";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(427, 570);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(79, 20);
            this.lbFiltro.TabIndex = 32;
            this.lbFiltro.Text = "Filtro :  ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(489, 571);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 23);
            this.textBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1416, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbCampo);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.bBorrar);
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
            this.TextChanged += new System.EventHandler(this.MenuPrincipal_TextChanged);
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
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Button bDetalle;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btcerrar;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

