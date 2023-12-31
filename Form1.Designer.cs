﻿namespace Analisis_numerico
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grBoxSalida = new System.Windows.Forms.GroupBox();
            this.panelGraficador = new System.Windows.Forms.Panel();
            this.lblEfectividadResultado = new System.Windows.Forms.Label();
            this.lblEfectividad = new System.Windows.Forms.Label();
            this.lblCorrelacionResultado = new System.Windows.Forms.Label();
            this.lblCorrelacion = new System.Windows.Forms.Label();
            this.lblFResultado = new System.Windows.Forms.Label();
            this.lblFObtenida = new System.Windows.Forms.Label();
            this.grBoxEntrada = new System.Windows.Forms.GroupBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.panelIngresados = new System.Windows.Forms.Panel();
            this.lblIngresados = new System.Windows.Forms.Label();
            this.btnBorrarT = new System.Windows.Forms.Button();
            this.btnBorrarU = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.txtBoxTole = new System.Windows.Forms.TextBox();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gpBoxEntradaU4 = new System.Windows.Forms.GroupBox();
            this.gpBoxResultadoU4 = new System.Windows.Forms.GroupBox();
            this.lblFxU4 = new System.Windows.Forms.Label();
            this.lblXiU4 = new System.Windows.Forms.Label();
            this.lblXdU4 = new System.Windows.Forms.Label();
            this.lblCantInterU4 = new System.Windows.Forms.Label();
            this.lblMetodoU4 = new System.Windows.Forms.Label();
            this.lblAreaU4 = new System.Windows.Forms.Label();
            this.txtFxU4 = new System.Windows.Forms.TextBox();
            this.txtXiU4 = new System.Windows.Forms.TextBox();
            this.txtXdU4 = new System.Windows.Forms.TextBox();
            this.txtCantInterU4 = new System.Windows.Forms.TextBox();
            this.cmbMetodosU4 = new System.Windows.Forms.ComboBox();
            this.btnCalcularU4 = new System.Windows.Forms.Button();
            this.lblAreaResultadoU4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grBoxSalida.SuspendLayout();
            this.grBoxEntrada.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gpBoxEntradaU4.SuspendLayout();
            this.gpBoxResultadoU4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grBoxSalida);
            this.tabPage3.Controls.Add(this.grBoxEntrada);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1010, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Unidad 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grBoxSalida
            // 
            this.grBoxSalida.Controls.Add(this.panelGraficador);
            this.grBoxSalida.Controls.Add(this.lblEfectividadResultado);
            this.grBoxSalida.Controls.Add(this.lblEfectividad);
            this.grBoxSalida.Controls.Add(this.lblCorrelacionResultado);
            this.grBoxSalida.Controls.Add(this.lblCorrelacion);
            this.grBoxSalida.Controls.Add(this.lblFResultado);
            this.grBoxSalida.Controls.Add(this.lblFObtenida);
            this.grBoxSalida.Location = new System.Drawing.Point(480, 6);
            this.grBoxSalida.Name = "grBoxSalida";
            this.grBoxSalida.Size = new System.Drawing.Size(524, 484);
            this.grBoxSalida.TabIndex = 1;
            this.grBoxSalida.TabStop = false;
            this.grBoxSalida.Text = "Datos de salida";
            // 
            // panelGraficador
            // 
            this.panelGraficador.Location = new System.Drawing.Point(6, 138);
            this.panelGraficador.Name = "panelGraficador";
            this.panelGraficador.Size = new System.Drawing.Size(512, 334);
            this.panelGraficador.TabIndex = 6;
            // 
            // lblEfectividadResultado
            // 
            this.lblEfectividadResultado.AutoSize = true;
            this.lblEfectividadResultado.Location = new System.Drawing.Point(181, 111);
            this.lblEfectividadResultado.Name = "lblEfectividadResultado";
            this.lblEfectividadResultado.Size = new System.Drawing.Size(15, 24);
            this.lblEfectividadResultado.TabIndex = 5;
            this.lblEfectividadResultado.Text = "-";
            // 
            // lblEfectividad
            // 
            this.lblEfectividad.AutoSize = true;
            this.lblEfectividad.Location = new System.Drawing.Point(6, 108);
            this.lblEfectividad.Name = "lblEfectividad";
            this.lblEfectividad.Size = new System.Drawing.Size(169, 24);
            this.lblEfectividad.TabIndex = 4;
            this.lblEfectividad.Text = "Efectividad del ajuste:";
            // 
            // lblCorrelacionResultado
            // 
            this.lblCorrelacionResultado.AutoSize = true;
            this.lblCorrelacionResultado.Location = new System.Drawing.Point(181, 78);
            this.lblCorrelacionResultado.Name = "lblCorrelacionResultado";
            this.lblCorrelacionResultado.Size = new System.Drawing.Size(15, 24);
            this.lblCorrelacionResultado.TabIndex = 3;
            this.lblCorrelacionResultado.Text = "-";
            // 
            // lblCorrelacion
            // 
            this.lblCorrelacion.AutoSize = true;
            this.lblCorrelacion.Location = new System.Drawing.Point(59, 78);
            this.lblCorrelacion.Name = "lblCorrelacion";
            this.lblCorrelacion.Size = new System.Drawing.Size(116, 24);
            this.lblCorrelacion.TabIndex = 2;
            this.lblCorrelacion.Text = "Correlacion (r):";
            // 
            // lblFResultado
            // 
            this.lblFResultado.AutoSize = true;
            this.lblFResultado.Location = new System.Drawing.Point(181, 44);
            this.lblFResultado.Name = "lblFResultado";
            this.lblFResultado.Size = new System.Drawing.Size(15, 24);
            this.lblFResultado.TabIndex = 1;
            this.lblFResultado.Text = "-";
            // 
            // lblFObtenida
            // 
            this.lblFObtenida.AutoSize = true;
            this.lblFObtenida.Location = new System.Drawing.Point(36, 42);
            this.lblFObtenida.Name = "lblFObtenida";
            this.lblFObtenida.Size = new System.Drawing.Size(139, 24);
            this.lblFObtenida.TabIndex = 0;
            this.lblFObtenida.Text = "Funcion obtenida:";
            // 
            // grBoxEntrada
            // 
            this.grBoxEntrada.Controls.Add(this.txtGrado);
            this.grBoxEntrada.Controls.Add(this.lblGrado);
            this.grBoxEntrada.Controls.Add(this.panelIngresados);
            this.grBoxEntrada.Controls.Add(this.lblIngresados);
            this.grBoxEntrada.Controls.Add(this.btnBorrarT);
            this.grBoxEntrada.Controls.Add(this.btnBorrarU);
            this.grBoxEntrada.Controls.Add(this.label4);
            this.grBoxEntrada.Controls.Add(this.btnCalcula);
            this.grBoxEntrada.Controls.Add(this.label3);
            this.grBoxEntrada.Controls.Add(this.lblTolerancia);
            this.grBoxEntrada.Controls.Add(this.txtBoxTole);
            this.grBoxEntrada.Controls.Add(this.txtBoxY);
            this.grBoxEntrada.Controls.Add(this.cmbMetodo);
            this.grBoxEntrada.Controls.Add(this.txtBoxX);
            this.grBoxEntrada.Controls.Add(this.btnCargar);
            this.grBoxEntrada.Controls.Add(this.lblIngresar);
            this.grBoxEntrada.Location = new System.Drawing.Point(8, 6);
            this.grBoxEntrada.Name = "grBoxEntrada";
            this.grBoxEntrada.Size = new System.Drawing.Size(466, 478);
            this.grBoxEntrada.TabIndex = 0;
            this.grBoxEntrada.TabStop = false;
            this.grBoxEntrada.Text = "Datos de entrada";
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(173, 152);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(121, 30);
            this.txtGrado.TabIndex = 15;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(107, 155);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(60, 24);
            this.lblGrado.TabIndex = 14;
            this.lblGrado.Text = "Grado:";
            // 
            // panelIngresados
            // 
            this.panelIngresados.BackColor = System.Drawing.Color.Silver;
            this.panelIngresados.Location = new System.Drawing.Point(173, 191);
            this.panelIngresados.Name = "panelIngresados";
            this.panelIngresados.Size = new System.Drawing.Size(166, 281);
            this.panelIngresados.TabIndex = 13;
            // 
            // lblIngresados
            // 
            this.lblIngresados.AutoSize = true;
            this.lblIngresados.Location = new System.Drawing.Point(18, 191);
            this.lblIngresados.Name = "lblIngresados";
            this.lblIngresados.Size = new System.Drawing.Size(149, 24);
            this.lblIngresados.TabIndex = 12;
            this.lblIngresados.Text = "Puntos ingresados:";
            // 
            // btnBorrarT
            // 
            this.btnBorrarT.Location = new System.Drawing.Point(345, 227);
            this.btnBorrarT.Name = "btnBorrarT";
            this.btnBorrarT.Size = new System.Drawing.Size(113, 32);
            this.btnBorrarT.TabIndex = 11;
            this.btnBorrarT.Text = "Borrar todos";
            this.btnBorrarT.UseVisualStyleBackColor = true;
            this.btnBorrarT.Click += new System.EventHandler(this.btnBorrarT_Click);
            // 
            // btnBorrarU
            // 
            this.btnBorrarU.Location = new System.Drawing.Point(345, 191);
            this.btnBorrarU.Name = "btnBorrarU";
            this.btnBorrarU.Size = new System.Drawing.Size(113, 32);
            this.btnBorrarU.TabIndex = 10;
            this.btnBorrarU.Text = "Borrar ultimo";
            this.btnBorrarU.UseVisualStyleBackColor = true;
            this.btnBorrarU.Click += new System.EventHandler(this.btnBorrarU_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Metodo a utilizar:";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(345, 107);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(113, 33);
            this.btnCalcula.TabIndex = 8;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 7;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Location = new System.Drawing.Point(78, 75);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(89, 24);
            this.lblTolerancia.TabIndex = 6;
            this.lblTolerancia.Text = "Tolerancia:";
            // 
            // txtBoxTole
            // 
            this.txtBoxTole.Location = new System.Drawing.Point(173, 72);
            this.txtBoxTole.Name = "txtBoxTole";
            this.txtBoxTole.Size = new System.Drawing.Size(80, 30);
            this.txtBoxTole.TabIndex = 5;
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(259, 36);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(80, 30);
            this.txtBoxY.TabIndex = 4;
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Regresion Lineal",
            "Regresion Polinomial"});
            this.cmbMetodo.Location = new System.Drawing.Point(173, 108);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(121, 32);
            this.cmbMetodo.TabIndex = 3;
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(173, 36);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(80, 30);
            this.txtBoxX.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(345, 36);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(113, 32);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(0, 39);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(167, 24);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Ingresar punto (X, Y):";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gpBoxResultadoU4);
            this.tabPage4.Controls.Add(this.gpBoxEntradaU4);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1010, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Unidad 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gpBoxEntradaU4
            // 
            this.gpBoxEntradaU4.Controls.Add(this.btnCalcularU4);
            this.gpBoxEntradaU4.Controls.Add(this.cmbMetodosU4);
            this.gpBoxEntradaU4.Controls.Add(this.txtCantInterU4);
            this.gpBoxEntradaU4.Controls.Add(this.txtXdU4);
            this.gpBoxEntradaU4.Controls.Add(this.txtXiU4);
            this.gpBoxEntradaU4.Controls.Add(this.txtFxU4);
            this.gpBoxEntradaU4.Controls.Add(this.lblMetodoU4);
            this.gpBoxEntradaU4.Controls.Add(this.lblCantInterU4);
            this.gpBoxEntradaU4.Controls.Add(this.lblXdU4);
            this.gpBoxEntradaU4.Controls.Add(this.lblXiU4);
            this.gpBoxEntradaU4.Controls.Add(this.lblFxU4);
            this.gpBoxEntradaU4.Location = new System.Drawing.Point(8, 6);
            this.gpBoxEntradaU4.Name = "gpBoxEntradaU4";
            this.gpBoxEntradaU4.Size = new System.Drawing.Size(490, 478);
            this.gpBoxEntradaU4.TabIndex = 0;
            this.gpBoxEntradaU4.TabStop = false;
            this.gpBoxEntradaU4.Text = "Datos de entrada";
            // 
            // gpBoxResultadoU4
            // 
            this.gpBoxResultadoU4.Controls.Add(this.lblAreaResultadoU4);
            this.gpBoxResultadoU4.Controls.Add(this.lblAreaU4);
            this.gpBoxResultadoU4.Location = new System.Drawing.Point(504, 6);
            this.gpBoxResultadoU4.Name = "gpBoxResultadoU4";
            this.gpBoxResultadoU4.Size = new System.Drawing.Size(500, 478);
            this.gpBoxResultadoU4.TabIndex = 1;
            this.gpBoxResultadoU4.TabStop = false;
            this.gpBoxResultadoU4.Text = "Resultado";
            // 
            // lblFxU4
            // 
            this.lblFxU4.AutoSize = true;
            this.lblFxU4.Location = new System.Drawing.Point(6, 40);
            this.lblFxU4.Name = "lblFxU4";
            this.lblFxU4.Size = new System.Drawing.Size(48, 24);
            this.lblFxU4.TabIndex = 0;
            this.lblFxU4.Text = "F(x): ";
            // 
            // lblXiU4
            // 
            this.lblXiU4.AutoSize = true;
            this.lblXiU4.Location = new System.Drawing.Point(20, 91);
            this.lblXiU4.Name = "lblXiU4";
            this.lblXiU4.Size = new System.Drawing.Size(34, 24);
            this.lblXiU4.TabIndex = 1;
            this.lblXiU4.Text = "Xi: ";
            // 
            // lblXdU4
            // 
            this.lblXdU4.AutoSize = true;
            this.lblXdU4.Location = new System.Drawing.Point(156, 91);
            this.lblXdU4.Name = "lblXdU4";
            this.lblXdU4.Size = new System.Drawing.Size(40, 24);
            this.lblXdU4.TabIndex = 2;
            this.lblXdU4.Text = "Xd: ";
            // 
            // lblCantInterU4
            // 
            this.lblCantInterU4.AutoSize = true;
            this.lblCantInterU4.Location = new System.Drawing.Point(6, 144);
            this.lblCantInterU4.Name = "lblCantInterU4";
            this.lblCantInterU4.Size = new System.Drawing.Size(227, 24);
            this.lblCantInterU4.TabIndex = 3;
            this.lblCantInterU4.Text = "Cantidad de subintervalos (n):";
            // 
            // lblMetodoU4
            // 
            this.lblMetodoU4.AutoSize = true;
            this.lblMetodoU4.Location = new System.Drawing.Point(6, 187);
            this.lblMetodoU4.Name = "lblMetodoU4";
            this.lblMetodoU4.Size = new System.Drawing.Size(71, 24);
            this.lblMetodoU4.TabIndex = 4;
            this.lblMetodoU4.Text = "Metodo:";
            // 
            // lblAreaU4
            // 
            this.lblAreaU4.AutoSize = true;
            this.lblAreaU4.Location = new System.Drawing.Point(16, 40);
            this.lblAreaU4.Name = "lblAreaU4";
            this.lblAreaU4.Size = new System.Drawing.Size(49, 24);
            this.lblAreaU4.TabIndex = 5;
            this.lblAreaU4.Text = "Area:";
            // 
            // txtFxU4
            // 
            this.txtFxU4.Location = new System.Drawing.Point(60, 37);
            this.txtFxU4.Name = "txtFxU4";
            this.txtFxU4.Size = new System.Drawing.Size(297, 30);
            this.txtFxU4.TabIndex = 5;
            // 
            // txtXiU4
            // 
            this.txtXiU4.Location = new System.Drawing.Point(60, 85);
            this.txtXiU4.Name = "txtXiU4";
            this.txtXiU4.Size = new System.Drawing.Size(80, 30);
            this.txtXiU4.TabIndex = 6;
            // 
            // txtXdU4
            // 
            this.txtXdU4.Location = new System.Drawing.Point(202, 85);
            this.txtXdU4.Name = "txtXdU4";
            this.txtXdU4.Size = new System.Drawing.Size(80, 30);
            this.txtXdU4.TabIndex = 7;
            // 
            // txtCantInterU4
            // 
            this.txtCantInterU4.Location = new System.Drawing.Point(239, 141);
            this.txtCantInterU4.Name = "txtCantInterU4";
            this.txtCantInterU4.Size = new System.Drawing.Size(118, 30);
            this.txtCantInterU4.TabIndex = 9;
            // 
            // cmbMetodosU4
            // 
            this.cmbMetodosU4.FormattingEnabled = true;
            this.cmbMetodosU4.Items.AddRange(new object[] {
            "Trapecios simples",
            "Trapecios multiples",
            "Simpson 1/3 simple",
            "Simpson 1/3 multiple",
            "Simpson 3/8",
            "Simpson 1/3 multiple con impar S.3/8"});
            this.cmbMetodosU4.Location = new System.Drawing.Point(83, 184);
            this.cmbMetodosU4.Name = "cmbMetodosU4";
            this.cmbMetodosU4.Size = new System.Drawing.Size(274, 32);
            this.cmbMetodosU4.TabIndex = 10;
            // 
            // btnCalcularU4
            // 
            this.btnCalcularU4.Location = new System.Drawing.Point(83, 240);
            this.btnCalcularU4.Name = "btnCalcularU4";
            this.btnCalcularU4.Size = new System.Drawing.Size(274, 35);
            this.btnCalcularU4.TabIndex = 11;
            this.btnCalcularU4.Text = "Calcular";
            this.btnCalcularU4.UseVisualStyleBackColor = true;
            this.btnCalcularU4.Click += new System.EventHandler(this.btnCalcularU4_Click);
            // 
            // lblAreaResultadoU4
            // 
            this.lblAreaResultadoU4.AutoSize = true;
            this.lblAreaResultadoU4.Location = new System.Drawing.Point(71, 40);
            this.lblAreaResultadoU4.Name = "lblAreaResultadoU4";
            this.lblAreaResultadoU4.Size = new System.Drawing.Size(15, 24);
            this.lblAreaResultadoU4.TabIndex = 6;
            this.lblAreaResultadoU4.Text = "-";
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
            this.tabPage3.ResumeLayout(false);
            this.grBoxSalida.ResumeLayout(false);
            this.grBoxSalida.PerformLayout();
            this.grBoxEntrada.ResumeLayout(false);
            this.grBoxEntrada.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gpBoxEntradaU4.ResumeLayout(false);
            this.gpBoxEntradaU4.PerformLayout();
            this.gpBoxResultadoU4.ResumeLayout(false);
            this.gpBoxResultadoU4.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grBoxSalida;
        private System.Windows.Forms.GroupBox grBoxEntrada;
        private System.Windows.Forms.Button btnBorrarT;
        private System.Windows.Forms.Button btnBorrarU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.TextBox txtBoxTole;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblIngresados;
        private System.Windows.Forms.Panel panelIngresados;
        private System.Windows.Forms.Panel panelGraficador;
        private System.Windows.Forms.Label lblEfectividadResultado;
        private System.Windows.Forms.Label lblEfectividad;
        private System.Windows.Forms.Label lblCorrelacionResultado;
        private System.Windows.Forms.Label lblCorrelacion;
        private System.Windows.Forms.Label lblFResultado;
        private System.Windows.Forms.Label lblFObtenida;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.GroupBox gpBoxResultadoU4;
        private System.Windows.Forms.Label lblAreaU4;
        private System.Windows.Forms.GroupBox gpBoxEntradaU4;
        private System.Windows.Forms.Label lblMetodoU4;
        private System.Windows.Forms.Label lblCantInterU4;
        private System.Windows.Forms.Label lblXdU4;
        private System.Windows.Forms.Label lblXiU4;
        private System.Windows.Forms.Label lblFxU4;
        private System.Windows.Forms.TextBox txtCantInterU4;
        private System.Windows.Forms.TextBox txtXdU4;
        private System.Windows.Forms.TextBox txtXiU4;
        private System.Windows.Forms.TextBox txtFxU4;
        private System.Windows.Forms.Button btnCalcularU4;
        private System.Windows.Forms.ComboBox cmbMetodosU4;
        private System.Windows.Forms.Label lblAreaResultadoU4;
    }
}

