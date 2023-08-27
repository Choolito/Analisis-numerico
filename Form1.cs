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
    }
}
