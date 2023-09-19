using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_numerico
{
    internal class Unidad2
    {
        public double[] GaussJordan (int dimension, double[,]matriz)
        {
            for (int i = 0; i < dimension; i++)
            {
                double coeficienteDiagonal = matriz[i, i];

                for (int j = i; j < dimension + 1; j++)
                {
                    matriz[i, j] /= coeficienteDiagonal;
                }
                for (int k = 0; k < dimension; k++)
                {
                    if (k != i)
                    {
                        double coeficienteCero = matriz[k, i];
                        for (int j = i; j < dimension + 1; j++)
                        {
                            matriz[k, j] -= (coeficienteCero * matriz[i, j]);
                        }
                    }
                }
            }
            double[] vectorResultante = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                vectorResultante[i] = matriz[i, dimension];
            }
            return vectorResultante;
        }
        public double[] GaussSeidel (int dimension, double[,] matriz)
        {
            double tolerancia = 0.0001;
            bool menorTolerancia = false;
            int contador = 0;
            double[] vectorResultado = new double[dimension];
            vectorResultado.Initialize();
            double[] vectorAnterior = new double[dimension];
            double resultado;
            double coeficienteIncognita;

            while (contador <= 100 && !menorTolerancia)
            {
                contador++;
                if (contador > 1)
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }
                for (int row = 0; row < dimension; row++)
                {
                    resultado = matriz[row, dimension];
                    coeficienteIncognita = matriz[row, row];
                    for (int col = 0; col < dimension; col++)
                    {
                        if (row != col)
                        {
                            resultado = resultado - (matriz[row, col] * vectorResultado[col]);
                        }
                    }
                    coeficienteIncognita = resultado / coeficienteIncognita;
                    vectorResultado[row] = coeficienteIncognita;
                }
                int contadorMismoResultado = 0;
                for (int i = 0; i < dimension; i++)
                {
                    if (Math.Abs(vectorResultado[i] - vectorAnterior[i]) < tolerancia)
                    {
                        contadorMismoResultado++;
                    }
                }
                menorTolerancia = contadorMismoResultado == dimension;
            }
            if (contador <= 100)
            {
                return vectorResultado;
            }
            else
            {
                return null;
            }
        }
    }
}
