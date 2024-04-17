namespace TP_WINFORM_PROGRAM3_
{
    partial class Form1
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
            this.HOLA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HOLA
            // 
            this.HOLA.AllowDrop = true;
            this.HOLA.CausesValidation = false;
            this.HOLA.Location = new System.Drawing.Point(353, 200);
            this.HOLA.Name = "HOLA";
            this.HOLA.Size = new System.Drawing.Size(75, 23);
            this.HOLA.TabIndex = 0;
            this.HOLA.Text = "HOLA";
            this.HOLA.UseVisualStyleBackColor = true;
            this.HOLA.Click += new System.EventHandler(this.HOLA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HOLA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HOLA;
    }
}

