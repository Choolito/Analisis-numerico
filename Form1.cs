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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoCerrado("Biseccion", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , double.Parse(txtXd.Text));
        }

        private void btnReglaF_Click(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoCerrado("Regla falsa", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , double.Parse(txtXd.Text));
        }

        private void btnNewRap_Click(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoAbierto("Newton-Raphson", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , 0);
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.MetodoAbierto("Secante", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , double.Parse(txtXd.Text));
        }

        private void lblXi_Click(object sender, EventArgs e)
        {

        }

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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDimension.Text, out int dimension))
            {
                MessageBox.Show("Indique la dimesnion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gBMatriz_Enter(object sender, EventArgs e)
        {

        }
    }
}
