using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_numerico
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //UNIDAD 1 INICIO
        
        private void btnBiseccion_Click_1(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoCerrado("Biseccion", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , double.Parse(txtXd.Text));
        }

        private void btnReglaF_Click_1(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoCerrado("Regla falsa", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , double.Parse(txtXd.Text));
        }

        private void btnNewRap_Click_1(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoAbierto("Newton-Raphson", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , 0);
        }

        private void btnSecante_Click_1(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoAbierto("Secante", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , double.Parse(txtXd.Text));
        }
        //UNIDAD 1 FIN

        //UNIDAD 2 INICIO
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDimension.Text, out int dimension))
            {
                MessageBox.Show("Indique la dimension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dimension = int.Parse(txtDimension.Text);
                int puntoX = 30;
                int puntoY = 30;

                gBMatriz.Controls.Clear();

                for(int row=0; row < dimension; row++)
                {
                    for (int col=0; col < dimension + 1; col++)
                    {
                        string nombre = $"({row},{col})";

                        TextBox textBox = new TextBox();
                        textBox.Name = nombre;
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(textBox, nombre);
                        textBox.Location = new Point(puntoX, puntoY);
                        textBox.Size = new Size(100, 30);
                        if (col==dimension)
                        {
                            textBox.BackColor = Color.LightSkyBlue;
                        }
                        gBMatriz.Controls.Add(textBox);
                        gBMatriz.Show();
                        puntoX += 110;
                    }
                    puntoX = 30;
                    puntoY += 30;
                }
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dimension = int.Parse(txtDimension.Text);
            double[,]matriz = GuardarMatriz(dimension);
            MessageBox.Show("Matriz cargada con exito");
            double[] vectorResultado = new double[dimension];
            Unidad2 unidad2 = new Unidad2();
            switch (cboxMetodo.SelectedIndex)
            {
                case 0:
                    vectorResultado = unidad2.GaussJordan(dimension, matriz);
                    break;
                case 1:
                    vectorResultado = unidad2.GaussSeidel(dimension, matriz);
                    break;
            }
            string resultados = "";
            if (vectorResultado != null)
            {
                for (int i = 0; i < vectorResultado.Length; i++)
                {
                    resultados += $"X{i + 1} =  {vectorResultado[i]}\n";
                }
            }
            else
            {
                resultados = "Se paso de iteraciones.";
            }
            MessageBox.Show(resultados);
        }
        private double[,] GuardarMatriz (int dimension)
        {
            double[,] matriz = new double[dimension, dimension + 1];
            for (int row=0; row <dimension; row++)
            {
                for (int col = 0; col < dimension+1; col++)
                {
                    Control textBox =  gBMatriz.Controls.Find($"({row},{col})", true).First();

                    if (!double.TryParse((textBox as TextBox).Text, out double numero))
                    {
                        return null;
                    }

                    matriz[row, col] = numero;
                }
            }
            return matriz;
        }
        //UNIDAD 2 FIN
    }
}
