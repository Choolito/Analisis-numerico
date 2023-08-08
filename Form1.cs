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
            Calculo analizadorFunciones = new Calculo();
            string funcion = txtFuncion.Text;
            double tolerancia = double.Parse(txtTole.Text);
            int iteraciones = int.Parse(txtIteracion.Text);
            double Xi = double.Parse(txtXi.Text);
            double Xd = double.Parse(txtXd.Text);

            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xd) > 0)
                {
                    MessageBox.Show("En el intervalo entre Xi y Xd no se encuentra la raiz. Modifique los valores.");
                    txtXi.Clear();
                    txtXd.Clear();
                }
                else if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xd) == 0)
                {
                    if (analizadorFunciones.EvaluaFx(Xi)==0)
                    {
                        MessageBox.Show("La raiz es Xi. Su valor es: "+Xi+". No realizo ninguna iteracion " +
                            "por lo tanto tampoco tiene un error. Y si converge en ese valor.");
                    }
                    else
                    {
                        MessageBox.Show("La raiz es Xd. Su valor es: " + Xd + ". No realizo ninguna iteracion " +
                            "por lo tanto tampoco tiene un error. Y si converge en ese valor.");
                    }
                }
                else
                {
                    double XrAnt = 0;
                    double Xr = 0;
                    double error = 0;
                    for (int i=1; i<=iteraciones; i++)
                    {
                        Xr = (Xi + Xd) / 2;
                        error = Math.Abs((Xr - XrAnt) / Xr);
                        if (Math.Abs(analizadorFunciones.EvaluaFx(Xr))<tolerancia || error < tolerancia)
                        {
                            MessageBox.Show("La raiz es Xr. Su valor es " + Xr + " realizando " + i + " iteraciones con un error de " +
                                Math.Round(error, 10));
                            break;
                        }
                        else
                        {
                            if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xr) > 0)
                            {
                                Xi = Xr;
                            }
                            else
                            {
                                Xd = Xr;
                            }
                            XrAnt = Xr;
                        }
                    }
                    if (Math.Abs(analizadorFunciones.EvaluaFx(Xr)) >= tolerancia && error >= tolerancia)
                    {
                        MessageBox.Show("La raiz terminó siendo Xr. Su valor es " + Xr + " realizando " + iteraciones + " iteraciones, siendo todas, con un error de " +
                            Math.Round(error, 10));
                    }
                }              
            }
            else
            {         
                MessageBox.Show("Error de sintaxis en la funcion. Verifique lo escrito.");
            }
        }

        private void btnReglaF_Click(object sender, EventArgs e)
        {
            Calculo analizadorFunciones = new Calculo();
            string funcion = txtFuncion.Text;
            double tolerancia = double.Parse(txtTole.Text);
            int iteraciones = int.Parse(txtIteracion.Text);
            double Xi = double.Parse(txtXi.Text);
            double Xd = double.Parse(txtXd.Text);

            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xd) > 0)
                {
                    MessageBox.Show("En el intervalo entre Xi y Xd no se encuentra la raiz. Modifique los valores.");
                    txtXi.Clear();
                    txtXd.Clear();
                }
                else if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xd) == 0)
                {
                    if (analizadorFunciones.EvaluaFx(Xi) == 0)
                    {
                        MessageBox.Show("La raiz es Xi. Su valor es: " + Xi + ". No realizo ninguna iteracion " +
                            "por lo tanto tampoco tiene un error. Y si converge en ese valor.");
                    }
                    else
                    {
                        MessageBox.Show("La raiz es Xd. Su valor es: " + Xd + ". No realizo ninguna iteracion " +
                            "por lo tanto tampoco tiene un error. Y si converge en ese valor.");
                    }
                }
                else
                {
                    double XrAnt = 0;
                    double Xr = 0;
                    double error = 0;
                    for (int i = 1; i <= iteraciones; i++)
                    {
                        Xr = (analizadorFunciones.EvaluaFx(Xd) * Xi - analizadorFunciones.EvaluaFx(Xi) * Xd) /
                            (analizadorFunciones.EvaluaFx(Xd) - analizadorFunciones.EvaluaFx(Xi));
                        error = Math.Abs((Xr - XrAnt) / Xr);
                        if (Math.Abs(analizadorFunciones.EvaluaFx(Xr)) < tolerancia || error < tolerancia)
                        {
                            MessageBox.Show("La raiz es Xr. Su valor es " + Xr + " realizando " + i + " iteraciones con un error de " +
                                Math.Round(error, 10));
                            break;
                        }
                        else
                        {
                            if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xr) > 0)
                            {
                                Xi = Xr;
                            }
                            else
                            {
                                Xd = Xr;
                            }
                            XrAnt = Xr;
                        }
                    }
                    if (Math.Abs(analizadorFunciones.EvaluaFx(Xr)) >= tolerancia && error >= tolerancia)
                    {
                        MessageBox.Show("La raiz terminó siendo Xr. Su valor es " + Xr + " realizando " + iteraciones + " iteraciones, siendo todas, con un error de " +
                            Math.Round(error, 10));
                    }
                }
            }
            else
            {
                MessageBox.Show("Error de sintaxis en la funcion. Verifique lo escrito.");
            }
        }
    }
}
