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
            this.lblFuncion = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtIteracion = new System.Windows.Forms.TextBox();
            this.lblIter = new System.Windows.Forms.Label();
            this.txtTole = new System.Windows.Forms.TextBox();
            this.lblTole = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.lblXd = new System.Windows.Forms.Label();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.btnReglaF = new System.Windows.Forms.Button();
            this.btnNewRap = new System.Windows.Forms.Button();
            this.btnSecante = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
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
            this.unidad1TSMI.Size = new System.Drawing.Size(88, 23);
            this.unidad1TSMI.Text = "Unidad 1";
            // 
            // unidad2TSMI
            // 
            this.unidad2TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad2TSMI.Name = "unidad2TSMI";
            this.unidad2TSMI.Size = new System.Drawing.Size(88, 23);
            this.unidad2TSMI.Text = "Unidad 2";
            // 
            // unidad3TSMI
            // 
            this.unidad3TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad3TSMI.Name = "unidad3TSMI";
            this.unidad3TSMI.Size = new System.Drawing.Size(88, 23);
            this.unidad3TSMI.Text = "Unidad 3";
            // 
            // unidad4TSMI
            // 
            this.unidad4TSMI.Font = new System.Drawing.Font("Arial", 10F);
            this.unidad4TSMI.Name = "unidad4TSMI";
            this.unidad4TSMI.Size = new System.Drawing.Size(88, 23);
            this.unidad4TSMI.Text = "Unidad 4";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(12, 49);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(82, 24);
            this.lblFuncion.TabIndex = 1;
            this.lblFuncion.Text = "Funcion =";
            this.lblFuncion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(116, 46);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 30);
            this.txtFuncion.TabIndex = 2;
            // 
            // txtIteracion
            // 
            this.txtIteracion.Location = new System.Drawing.Point(116, 82);
            this.txtIteracion.Name = "txtIteracion";
            this.txtIteracion.Size = new System.Drawing.Size(100, 30);
            this.txtIteracion.TabIndex = 4;
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Location = new System.Drawing.Point(12, 85);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(87, 24);
            this.lblIter.TabIndex = 3;
            this.lblIter.Text = "Iteracion =";
            // 
            // txtTole
            // 
            this.txtTole.Location = new System.Drawing.Point(116, 118);
            this.txtTole.Name = "txtTole";
            this.txtTole.Size = new System.Drawing.Size(100, 30);
            this.txtTole.TabIndex = 6;
            // 
            // lblTole
            // 
            this.lblTole.AutoSize = true;
            this.lblTole.Location = new System.Drawing.Point(12, 121);
            this.lblTole.Name = "lblTole";
            this.lblTole.Size = new System.Drawing.Size(99, 24);
            this.lblTole.TabIndex = 5;
            this.lblTole.Text = "Tolerancia =";
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(116, 154);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 30);
            this.txtXi.TabIndex = 8;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(12, 157);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(75, 24);
            this.lblXi.TabIndex = 7;
            this.lblXi.Text = "Xi(Xini) =";
            this.lblXi.Click += new System.EventHandler(this.lblXi_Click);
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(116, 190);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 30);
            this.txtXd.TabIndex = 10;
            // 
            // lblXd
            // 
            this.lblXd.AutoSize = true;
            this.lblXd.Location = new System.Drawing.Point(12, 193);
            this.lblXd.Name = "lblXd";
            this.lblXd.Size = new System.Drawing.Size(45, 24);
            this.lblXd.TabIndex = 9;
            this.lblXd.Text = "Xd =";
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Location = new System.Drawing.Point(475, 49);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(148, 37);
            this.btnBiseccion.TabIndex = 13;
            this.btnBiseccion.Text = "Biseccion";
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // btnReglaF
            // 
            this.btnReglaF.Location = new System.Drawing.Point(475, 92);
            this.btnReglaF.Name = "btnReglaF";
            this.btnReglaF.Size = new System.Drawing.Size(148, 37);
            this.btnReglaF.TabIndex = 14;
            this.btnReglaF.Text = "Regla Falsa";
            this.btnReglaF.UseVisualStyleBackColor = true;
            this.btnReglaF.Click += new System.EventHandler(this.btnReglaF_Click);
            // 
            // btnNewRap
            // 
            this.btnNewRap.Location = new System.Drawing.Point(475, 135);
            this.btnNewRap.Name = "btnNewRap";
            this.btnNewRap.Size = new System.Drawing.Size(148, 37);
            this.btnNewRap.TabIndex = 15;
            this.btnNewRap.Text = "Newton-Rapshon";
            this.btnNewRap.UseVisualStyleBackColor = true;
            this.btnNewRap.Click += new System.EventHandler(this.btnNewRap_Click);
            // 
            // btnSecante
            // 
            this.btnSecante.Location = new System.Drawing.Point(475, 178);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(148, 37);
            this.btnSecante.TabIndex = 16;
            this.btnSecante.Text = "Secante";
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.btnSecante_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(1, 262);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(103, 24);
            this.lblRespuesta.TabIndex = 17;
            this.lblRespuesta.Text = "Respuesta =";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(112, 262);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 24);
            this.lblTexto.TabIndex = 18;
            this.lblTexto.Text = "null";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 398);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnSecante);
            this.Controls.Add(this.btnNewRap);
            this.Controls.Add(this.btnReglaF);
            this.Controls.Add(this.btnBiseccion);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.lblXd);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.txtTole);
            this.Controls.Add(this.lblTole);
            this.Controls.Add(this.txtIteracion);
            this.Controls.Add(this.lblIter);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtIteracion;
        private System.Windows.Forms.Label lblIter;
        private System.Windows.Forms.TextBox txtTole;
        private System.Windows.Forms.Label lblTole;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label lblXd;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Button btnReglaF;
        private System.Windows.Forms.Button btnNewRap;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblTexto;
    }
}

