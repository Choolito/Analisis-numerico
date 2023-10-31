using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Calculus;

namespace Analisis_numerico
{
    internal class Unidad4
    {
        private Calculo analizadorFunciones = new Calculo();
        public double CalcularIntegralTrapeciosSimple(string funcion, double xi, double xd)
        {
            if (analizadorFunciones.Sintaxis(funcion,'x'))
            {
                double resultado = ((analizadorFunciones.EvaluaFx(xi) + analizadorFunciones.EvaluaFx(xd)) * (xd - xi)) / 2;
                return resultado;
            }
            else
            {
                return double.NaN;
            }
        }

        public double CalcularIntegralTrapeciosMultiples(string funcion, double xi, double xd, int n)
        {
            if(analizadorFunciones.Sintaxis(funcion,'x'))
            {
                double h = (xd - xi) / n;
                double sum = 0;
                for(int i = 1; i < n; i++)
                {
                    sum += analizadorFunciones.EvaluaFx(xi + h * i);
                }
                double resultado = (h / 2) * (analizadorFunciones.EvaluaFx(xi) + 2 * sum +
                    analizadorFunciones.EvaluaFx(xd));
                return resultado;
            }
            else
            {
                return double.NaN;
            }
        }
        public double CalcularIntegralSimpson1_3Simple(string funcion, double xi, double xd)
        {
            if(analizadorFunciones.Sintaxis(funcion,'x'))
            {
                double h = (xd - xi) / 2;
                double resultado = (h / 3) * (analizadorFunciones.EvaluaFx(xi) + 4 * analizadorFunciones.EvaluaFx(xi + h) +
                    analizadorFunciones.EvaluaFx(xd));
                return resultado;
            }
            else
            {
                return double.NaN;
            }
        }
        
        public double CalcularIntegralSimpson1_3Multiple (string funcion, double xi, double xd, int n)
        {
            if (analizadorFunciones.Sintaxis (funcion,'x'))
            {
                double h = (xd - xi) / n;
                double sumPares = 0;
                double sumImpares = 0;
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumPares += analizadorFunciones.EvaluaFx(xi + h * i);
                    }
                    else
                    {
                        sumImpares += analizadorFunciones.EvaluaFx(xi + h * i);
                    }
                }
                double resultado = (h / 3) * (analizadorFunciones.EvaluaFx(xi) + 4 * sumImpares +
                    2 * sumPares + analizadorFunciones.EvaluaFx(xd));
                return resultado;
            }
            else
            { return double.NaN; }
        }
        public double CalcularIntegralSimpson3_8(string funcion, double xi, double xd)
        {
            if (analizadorFunciones.Sintaxis(funcion,'x'))
            {
                double h = (xd-xi) / 3;
                double resultado = (3 * h / 8) * (analizadorFunciones.EvaluaFx(xi) + 3 * analizadorFunciones.EvaluaFx(xi + h) +
                    3 * analizadorFunciones.EvaluaFx(xi + 2 * h) + analizadorFunciones.EvaluaFx(xd));
                return resultado;

            }
            else { return double.NaN; }
        }

        public double CalcularIntegralSimpson1_3MultipleConImpar(string funcion, double xi, double xd, int n)
        {
            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sumPares = 0;
                double sumImpares = 0;
                double resultado = 0;
                bool simpson3_8Hecho = false;
                for (int i = 1; i < n; i++)
                {
                    if(n%2 != 0 && !simpson3_8Hecho)
                    {
                        double nuevoXi = xi + h * (n - 3);
                        resultado = CalcularIntegralSimpson3_8(funcion, xi, xd);
                        n = n - 3;
                        simpson3_8Hecho = true;
                    }
                    if (i % 2 == 0)
                    {
                        sumPares += analizadorFunciones.EvaluaFx(xi + h * i);
                    }
                    else
                    {
                        sumImpares += analizadorFunciones.EvaluaFx(xi + h * i);
                    }
                }
                resultado += (h / 3) * (analizadorFunciones.EvaluaFx(xi) + 4 * sumImpares +
                    2 * sumPares + analizadorFunciones.EvaluaFx(xd));
                return resultado;
            }
            else
            { return double.NaN; }
        }
    }
}
