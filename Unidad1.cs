using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_numerico
{
    internal class Unidad1
    {
        private Calculo analizadorFunciones=new Calculo();
        private double CalcularMetodo(string metodo, string funcion, double Xi, double Xd)
        {
            analizadorFunciones.Sintaxis(funcion, 'x');
            switch (metodo)
            {
                case "Biseccion":
                    return (Xi + Xd) / 2;
                case "Regla falsa":
                    return (analizadorFunciones.EvaluaFx(Xd) * Xi - analizadorFunciones.EvaluaFx(Xi) * Xd) /
                            (analizadorFunciones.EvaluaFx(Xd) - analizadorFunciones.EvaluaFx(Xi));
                case "Newton-Raphson":
                    double Xini = Xi;
                    double Deriv = Xd;
                    return (Xini - (analizadorFunciones.EvaluaFx(Xini) / Deriv));
                case "Secante":
                    return ((analizadorFunciones.EvaluaFx(Xd) * Xi) - (analizadorFunciones.EvaluaFx(Xi) * Xd)) /
                        (analizadorFunciones.EvaluaFx(Xd) - analizadorFunciones.EvaluaFx(Xi));
                default: throw new NotImplementedException();
            }
        }
        public void MetodoCerrado(string metodo, string funcion, double tolerancia, int iteraciones, double Xi, double Xd)
        {
            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                if (analizadorFunciones.EvaluaFx(Xi) * analizadorFunciones.EvaluaFx(Xd) > 0)
                {
                    MessageBox.Show("En el intervalo entre Xi y Xd no se encuentra la raiz. Modifique los valores.");
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
                        Xr = CalcularMetodo(metodo, funcion, Xi, Xd);
                        error = Math.Abs((Xr - XrAnt) / Xr);
                        if (Math.Abs(analizadorFunciones.EvaluaFx(Xr)) < tolerancia || error < tolerancia)
                        {
                            MessageBox.Show("La raiz es Xr. Su valor es " + Math.Round(Xr, 6) + " realizando " + i + " iteraciones con un error de " +
                                string.Format("{0:F6}", error));

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
                        MessageBox.Show("La raiz terminó siendo Xr. Su valor es " + Math.Round(Xr, 6) + " realizando " + iteraciones + " iteraciones, siendo todas, con un error de " +
                            string.Format("{0:F6}", error));
                    }
                }
            }
            else
            {
                MessageBox.Show("Error de sintaxis en la funcion. Verifique lo escrito.");
            }
        }
        public void MetodoAbierto(string metodo, string funcion, double tolerancia, int iteraciones, double Xi, double Xd)
        {
            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                double Error = 0;
                double Xr = 0;
                if (Math.Abs(analizadorFunciones.EvaluaFx(Xi)) < tolerancia)
                {
                    MessageBox.Show("La raiz es " + Math.Round(Xi, 6) + " (Xi)" + ".Con error de " +
                            string.Format("{0:F6}", Error));
                }
                else if (Math.Abs(analizadorFunciones.EvaluaFx(Xd)) < tolerancia && metodo == "Secante")
                {
                    MessageBox.Show("La raiz es " + Math.Round(Xd, 6) + " (Xd)" + ".Con error de " +
                            string.Format("{0:F6}", Error));
                }
                double XrAnterior = 0;
                for (int i = 1; i <= iteraciones; i++)
                {
                    if (metodo == "Secante")
                    {
                        Xr = CalcularMetodo(metodo, funcion, Xi, Xd);
                    }
                    else
                    {
                        double Deriv = (analizadorFunciones.EvaluaFx(Xi + tolerancia) - analizadorFunciones.EvaluaFx(Xi)) / tolerancia;
                        if (Math.Abs(Deriv) < tolerancia)
                        {
                            MessageBox.Show("ERROR. El metodo diverge.");
                            break;
                        }
                        Xr = CalcularMetodo(metodo, funcion, Xi, Deriv);
                    }
                    Error = Math.Abs((Xr - XrAnterior) / Xr);
                    if (Math.Abs(analizadorFunciones.EvaluaFx(Xr)) < tolerancia || Error < tolerancia)
                    {
                        MessageBox.Show("La raiz es " + Math.Round(Xr, 6) + " (Evaluar funcion) y sus iteraciones son " + i + ".Con error de " +
                            string.Format("{0:F6}", Error));
                        break;
                    }
                    else
                    {
                        if (metodo == "Newton-Raphson")
                        {
                            Xi = Xr;
                        }
                        else
                        {
                            Xi = Xd;
                            Xd = Xr;
                        }
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
    }

}
