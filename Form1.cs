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
            unidad1.MetodoAbierto("Newton-Rapshon", txtFuncion.Text, double.Parse(txtTole.Text), int.Parse(txtIteracion.Text), double.Parse(txtXi.Text)
                , 0);
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            Calculo analizadorFunciones = new Calculo();
            string funcion = txtFuncion.Text;
            double tolerancia = double.Parse(txtTole.Text);
            int iteraciones = int.Parse(txtIteracion.Text);
            double Xi = double.Parse(txtXi.Text);
            double Xd = double.Parse(txtXd.Text);
            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                double Error = 0;
                double Xr = 0;
                if (Math.Abs(analizadorFunciones.EvaluaFx(Xi)) < tolerancia)
                {
                    MessageBox.Show("La raiz es " + Math.Round(Xi, 6) + " (Xi)"+ ".Con error de " +
                            string.Format("{0:F6}", Error));
                }
                else if (Math.Abs(analizadorFunciones.EvaluaFx(Xd)) < tolerancia)
                {
                    MessageBox.Show("La raiz es " + Math.Round(Xd, 6) + " (Xd)" + ".Con error de " +
                            string.Format("{0:F6}", Error));
                }
                double XrAnterior = 0;
                for (int i = 1; i <= iteraciones; i++)
                {
                    Xr = ((analizadorFunciones.EvaluaFx(Xd)*Xi) - (analizadorFunciones.EvaluaFx(Xi)*Xd))/
                        (analizadorFunciones.EvaluaFx(Xd)-analizadorFunciones.EvaluaFx(Xi));
                    Error = Math.Abs((Xr - XrAnterior) / Xr);
                    if (Math.Abs(analizadorFunciones.EvaluaFx(Xr))<tolerancia || Error < tolerancia)
                    {
                        MessageBox.Show("La raiz es " + Math.Round(Xr, 6) + " (Evaluar funcion) y sus iteraciones son " + i + ".Con error de " +
                            string.Format("{0:F6}", Error));
                        break;
                    }
                    else
                    {
                        Xi = Xd;
                        Xd = Xr;
                        XrAnterior = Xr;
                    }
                }
                if (Math.Abs(analizadorFunciones.EvaluaFx(Xr)) >= tolerancia && Error >= tolerancia)
                {
                    MessageBox.Show("La raiz terminó siendo Xr. Su valor es " + Math.Round(Xr, 6) + " realizando " + iteraciones + " iteraciones, siendo todas, con un error de " +
                        string.Format("{0:F6}", Error));
                }
            }
            else
            {
                MessageBox.Show("Error de sintaxis en la funcion. Verifique lo escrito.");
            }
        }

        private void lblXi_Click(object sender, EventArgs e)
        {

        }
    }
}
