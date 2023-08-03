namespace Analisis_numerico
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unidad1TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad2TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad3TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad4TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidad1TSMI,
            this.unidad2TSMI,
            this.unidad3TSMI,
            this.unidad4TSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(654, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unidad1TSMI
            // 
            this.unidad1TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad1TSMI.Name = "unidad1TSMI";
            this.unidad1TSMI.Size = new System.Drawing.Size(88, 24);
            this.unidad1TSMI.Text = "Unidad 1";
            // 
            // unidad2TSMI
            // 
            this.unidad2TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad2TSMI.Name = "unidad2TSMI";
            this.unidad2TSMI.Size = new System.Drawing.Size(88, 24);
            this.unidad2TSMI.Text = "Unidad 2";
            // 
            // unidad3TSMI
            // 
            this.unidad3TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad3TSMI.Name = "unidad3TSMI";
            this.unidad3TSMI.Size = new System.Drawing.Size(88, 24);
            this.unidad3TSMI.Text = "Unidad 3";
            // 
            // unidad4TSMI
            // 
            this.unidad4TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad4TSMI.Name = "unidad4TSMI";
            this.unidad4TSMI.Size = new System.Drawing.Size(88, 24);
            this.unidad4TSMI.Text = "Unidad 4";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 398);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaseForm";
            this.Text = "Analisis numerico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unidad1TSMI;
        private System.Windows.Forms.ToolStripMenuItem unidad2TSMI;
        private System.Windows.Forms.ToolStripMenuItem unidad3TSMI;
        private System.Windows.Forms.ToolStripMenuItem unidad4TSMI;
    }
}

