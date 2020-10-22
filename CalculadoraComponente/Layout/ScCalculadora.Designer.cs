namespace CalculadoraComponente
{
    partial class LayoutCalculadora
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
            this.calculadoraLayout1 = new ComponenteCalculadora.CalculadoraLayout();
            this.SuspendLayout();
            // 
            // calculadoraLayout1
            // 
            this.calculadoraLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.calculadoraLayout1.Location = new System.Drawing.Point(-1, -2);
            this.calculadoraLayout1.Name = "calculadoraLayout1";
            this.calculadoraLayout1.Size = new System.Drawing.Size(317, 247);
            this.calculadoraLayout1.TabIndex = 0;
            // 
            // LayoutCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 238);
            this.Controls.Add(this.calculadoraLayout1);
            this.Name = "LayoutCalculadora";
            this.Text = "Calculadora v1.1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponenteCalculadora.CalculadoraLayout calculadoraLayout1;
    }
}

