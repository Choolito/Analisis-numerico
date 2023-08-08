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
                        MessageBox.Show("Xi es raiz.");
                        //falta mostrar los demas datos de salida
                    }
                    else
                    {
                        MessageBox.Show("Xd es raiz.");
                    }
                }
                else
                {
                    double XrAnt = 0;
                    double Xr = 0;
                    double error = 0;
                    for (int i=1; i<=iteraciones; i++)
                    {
                        Xr=(Xi+Xd)/2;
                        error = Math.Abs((Xr - XrAnt) / Xr);
                        if (Math.Abs(analizadorFunciones.EvaluaFx(Xr))<tolerancia || error < tolerancia)
                        {
                            MessageBox.Show("Xr es raiz." + Xr + "Iteraciones: "+i+" Error= "+error);
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
                    MessageBox.Show("Xr es: " + Xr + "Iteraciones: "+iteraciones);
                }
                
            }
            else
            {         
                MessageBox.Show("Error de sintaxis en la funcion");
            }

        }
    }
}
