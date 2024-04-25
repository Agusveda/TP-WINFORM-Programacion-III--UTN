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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.bAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bAplicar = new System.Windows.Forms.Button();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.bDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Listado de articulos";
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.AccessibleName = "";
            this.dgvarticulos.AllowUserToAddRows = false;
            this.dgvarticulos.AllowUserToDeleteRows = false;
            this.dgvarticulos.AllowUserToResizeColumns = false;
            this.dgvarticulos.AllowUserToResizeRows = false;
            this.dgvarticulos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvarticulos.Location = new System.Drawing.Point(137, 84);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(629, 297);
            this.dgvarticulos.TabIndex = 22;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(330, 401);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 11;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(492, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.Transparent;
            this.bBorrar.ForeColor = System.Drawing.Color.Red;
            this.bBorrar.Location = new System.Drawing.Point(691, 401);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 13;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            // 
            // textFiltro
            // 
            this.textFiltro.Location = new System.Drawing.Point(307, 53);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(222, 20);
            this.textFiltro.TabIndex = 17;
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(611, 53);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 20);
            this.bQuitar.TabIndex = 18;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            // 
            // bAplicar
            // 
            this.bAplicar.Location = new System.Drawing.Point(535, 53);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(70, 20);
            this.bAplicar.TabIndex = 19;
            this.bAplicar.Text = "Aplicar";
            this.bAplicar.UseVisualStyleBackColor = true;
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(206, 56);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(95, 13);
            this.lbBusqueda.TabIndex = 20;
            this.lbBusqueda.Text = "Busqueda por filtro";
            // 
            // bDetalle
            // 
            this.bDetalle.Location = new System.Drawing.Point(411, 401);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.Size = new System.Drawing.Size(75, 23);
            this.bDetalle.TabIndex = 25;
            this.bDetalle.Text = "Ver detalle";
            this.bDetalle.UseVisualStyleBackColor = true;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.bAplicar);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.textFiltro);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.bAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Button bDetalle;
    }
}

