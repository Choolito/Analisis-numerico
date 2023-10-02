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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnSecante = new System.Windows.Forms.Button();
            this.btnNewRap = new System.Windows.Forms.Button();
            this.btnReglaF = new System.Windows.Forms.Button();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.lblXd = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.txtTole = new System.Windows.Forms.TextBox();
            this.lblTole = new System.Windows.Forms.Label();
            this.txtIteracion = new System.Windows.Forms.TextBox();
            this.lblIter = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboxMetodo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.gBMatriz = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblDimension = new System.Windows.Forms.Label();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTexto);
            this.tabPage1.Controls.Add(this.lblRespuesta);
            this.tabPage1.Controls.Add(this.btnSecante);
            this.tabPage1.Controls.Add(this.btnNewRap);
            this.tabPage1.Controls.Add(this.btnReglaF);
            this.tabPage1.Controls.Add(this.btnBiseccion);
            this.tabPage1.Controls.Add(this.txtXd);
            this.tabPage1.Controls.Add(this.lblXd);
            this.tabPage1.Controls.Add(this.txtXi);
            this.tabPage1.Controls.Add(this.lblXi);
            this.tabPage1.Controls.Add(this.txtTole);
            this.tabPage1.Controls.Add(this.lblTole);
            this.tabPage1.Controls.Add(this.txtIteracion);
            this.tabPage1.Controls.Add(this.lblIter);
            this.tabPage1.Controls.Add(this.txtFuncion);
            this.tabPage1.Controls.Add(this.lblFuncion);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidad 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(123, 261);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 24);
            this.lblTexto.TabIndex = 34;
            this.lblTexto.Text = "null";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(12, 261);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(103, 24);
            this.lblRespuesta.TabIndex = 33;
            this.lblRespuesta.Text = "Respuesta =";
            // 
            // btnSecante
            // 
            this.btnSecante.Location = new System.Drawing.Point(486, 177);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(148, 37);
            this.btnSecante.TabIndex = 32;
            this.btnSecante.Text = "Secante";
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.btnSecante_Click_1);
            // 
            // btnNewRap
            // 
            this.btnNewRap.Location = new System.Drawing.Point(486, 134);
            this.btnNewRap.Name = "btnNewRap";
            this.btnNewRap.Size = new System.Drawing.Size(148, 37);
            this.btnNewRap.TabIndex = 31;
            this.btnNewRap.Text = "Newton-Rapshon";
            this.btnNewRap.UseVisualStyleBackColor = true;
            this.btnNewRap.Click += new System.EventHandler(this.btnNewRap_Click_1);
            // 
            // btnReglaF
            // 
            this.btnReglaF.Location = new System.Drawing.Point(486, 91);
            this.btnReglaF.Name = "btnReglaF";
            this.btnReglaF.Size = new System.Drawing.Size(148, 37);
            this.btnReglaF.TabIndex = 30;
            this.btnReglaF.Text = "Regla Falsa";
            this.btnReglaF.UseVisualStyleBackColor = true;
            this.btnReglaF.Click += new System.EventHandler(this.btnReglaF_Click_1);
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Location = new System.Drawing.Point(486, 48);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(148, 37);
            this.btnBiseccion.TabIndex = 29;
            this.btnBiseccion.Text = "Biseccion";
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click_1);
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(127, 189);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 30);
            this.txtXd.TabIndex = 28;
            // 
            // lblXd
            // 
            this.lblXd.AutoSize = true;
            this.lblXd.Location = new System.Drawing.Point(23, 192);
            this.lblXd.Name = "lblXd";
            this.lblXd.Size = new System.Drawing.Size(45, 24);
            this.lblXd.TabIndex = 27;
            this.lblXd.Text = "Xd =";
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(127, 153);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 30);
            this.txtXi.TabIndex = 26;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(23, 156);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(75, 24);
            this.lblXi.TabIndex = 25;
            this.lblXi.Text = "Xi(Xini) =";
            // 
            // txtTole
            // 
            this.txtTole.Location = new System.Drawing.Point(127, 117);
            this.txtTole.Name = "txtTole";
            this.txtTole.Size = new System.Drawing.Size(100, 30);
            this.txtTole.TabIndex = 24;
            // 
            // lblTole
            // 
            this.lblTole.AutoSize = true;
            this.lblTole.Location = new System.Drawing.Point(23, 120);
            this.lblTole.Name = "lblTole";
            this.lblTole.Size = new System.Drawing.Size(99, 24);
            this.lblTole.TabIndex = 23;
            this.lblTole.Text = "Tolerancia =";
            // 
            // txtIteracion
            // 
            this.txtIteracion.Location = new System.Drawing.Point(127, 81);
            this.txtIteracion.Name = "txtIteracion";
            this.txtIteracion.Size = new System.Drawing.Size(100, 30);
            this.txtIteracion.TabIndex = 22;
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Location = new System.Drawing.Point(23, 84);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(87, 24);
            this.lblIter.TabIndex = 21;
            this.lblIter.Text = "Iteracion =";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(127, 45);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 30);
            this.txtFuncion.TabIndex = 20;
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(23, 48);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(82, 24);
            this.lblFuncion.TabIndex = 19;
            this.lblFuncion.Text = "Funcion =";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboxMetodo);
            this.tabPage2.Controls.Add(this.btnCalcular);
            this.tabPage2.Controls.Add(this.lblMetodo);
            this.tabPage2.Controls.Add(this.gBMatriz);
            this.tabPage2.Controls.Add(this.btnGenerar);
            this.tabPage2.Controls.Add(this.lblDimension);
            this.tabPage2.Controls.Add(this.txtDimension);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unidad 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboxMetodo
            // 
            this.cboxMetodo.FormattingEnabled = true;
            this.cboxMetodo.Items.AddRange(new object[] {
            "GAUSS-JORDAN",
            "GAUSS-SEIDEL"});
            this.cboxMetodo.Location = new System.Drawing.Point(446, 9);
            this.cboxMetodo.Name = "cboxMetodo";
            this.cboxMetodo.Size = new System.Drawing.Size(121, 32);
            this.cboxMetodo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(573, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(374, 12);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(66, 24);
            this.lblMetodo.TabIndex = 5;
            this.lblMetodo.Text = "Metodo";
            // 
            // gBMatriz
            // 
            this.gBMatriz.Location = new System.Drawing.Point(8, 42);
            this.gBMatriz.Name = "gBMatriz";
            this.gBMatriz.Size = new System.Drawing.Size(996, 442);
            this.gBMatriz.TabIndex = 8;
            this.gBMatriz.TabStop = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(210, 6);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(81, 30);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(8, 9);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(87, 24);
            this.lblDimension.TabIndex = 1;
            this.lblDimension.Text = "Dimension";
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(104, 6);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 30);
            this.txtDimension.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 530);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.Text = "Analisis numerico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Button btnNewRap;
        private System.Windows.Forms.Button btnReglaF;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label lblXd;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.TextBox txtTole;
        private System.Windows.Forms.Label lblTole;
        private System.Windows.Forms.TextBox txtIteracion;
        private System.Windows.Forms.Label lblIter;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.GroupBox gBMatriz;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.ComboBox cboxMetodo;
    }
}

