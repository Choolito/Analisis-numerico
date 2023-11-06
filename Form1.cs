using Analisis_Numerico;
using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_numerico
{
    public partial class BaseForm : Form
    {
        public Graficador graficador { get; set; }

        public BaseForm()
        {
            InitializeComponent();

            SetPanelGrafica();
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

        //UNIDAD 3 INICIO
        public List<double[]> PuntosCargados = new List<double[]>();
        private void CargarPunto(double x, double y)
        {
            double[] punto = new double[2] { x, y };
            PuntosCargados.Add(punto);
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Unidad3 unidad3 = new Unidad3();
            if (txtBoxX.Text !="" && txtBoxY.Text != "")
            {
                //unidad3.CargarPunto(double.Parse(txtBoxX.Text), double.Parse(txtBoxY.Text));
                CargarPunto(double.Parse(txtBoxX.Text), double.Parse(txtBoxY.Text));

                Label puntoIngresado = new Label();
                puntoIngresado.Text = $"({txtBoxX.Text} " + "," + $" {txtBoxY.Text})";
                int cantElementos = PuntosCargados.Count();
                int puntoY = (cantElementos - 1) * 17;
                puntoIngresado.Location = new Point(0, puntoY);
                puntoIngresado.Size = new Size(100, 16);
                puntoIngresado.Font = new Font("Arial", 11);
                panelIngresados.Controls.Add(puntoIngresado);
                panelIngresados.Show();
                txtBoxX.Clear();
                txtBoxY.Clear();
            }
        }
        private double[,] GenerarMatrizPolinomial(int grado, List<double[]> puntosCargados)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension+1];
            double x = 0;
            double y = 0;
            foreach (double[] punto in puntosCargados)
            {
                x = punto[0];
                y = punto[1];
                for (int fila=0; fila<dimension; fila++)
                {
                    for (int col= 0; col<dimension; col++)
                    {
                        matriz[fila, col] += Math.Pow(x, fila + col);//Calcular coeficientes de las incognitas.
                    }
                    matriz[fila, dimension] += y * Math.Pow(x, fila); //Calcular terminos independientes.
                }
            }
            return matriz;
        }
        private void SetPanelGrafica()
        {
            panelGraficador.Controls.Clear();
            this.graficador = new Graficador();
            panelGraficador.Controls.Add(graficador);
            graficador.Dock = DockStyle.Fill;
        }

        private void btnBorrarU_Click(object sender, EventArgs e)
        {
            panelIngresados.Controls.RemoveAt(panelIngresados.Controls.Count - 1);
            PuntosCargados.Remove(PuntosCargados.Last());
        }

        private void btnBorrarT_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Unidad2 unidad2 = new Unidad2();
            SetPanelGrafica();
            double St = 0;
            double Sr = 0;
            int puntosEntrada = PuntosCargados.Count();
            string funcion = string.Empty;

            if (cmbMetodo.SelectedIndex == 0)
            {
                double SumX = 0;
                double SumY = 0;
                double SumXY = 0;
                double SumX2 = 0;
                //sumaX
                foreach (var punto in PuntosCargados)
                {
                    SumX += punto[0];
                }
                //sumaY
                foreach (var punto in PuntosCargados)
                {
                    SumY += punto[1];
                }
                //sumaXY
                foreach (var punto in PuntosCargados)
                {
                    SumXY += punto[0] * punto[1];
                }
                //sumaX2
                foreach (var punto in PuntosCargados)
                {
                    SumX2 += punto[0] * punto[0];
                }
                //Calculamos a1 y a0
                double a1 = (puntosEntrada * SumXY - SumX * SumY) /
                    (puntosEntrada * SumX2 - Math.Pow(SumX, 2));
                double a0 = (SumY / puntosEntrada) - a1 * (SumX / puntosEntrada);
                //Calculamos Sr y St
                foreach (var punto in PuntosCargados)
                {
                    St += Math.Pow(SumY / puntosEntrada - punto[1], 2);
                    Sr += Math.Pow(a1 * punto[0] + a0 - punto[1], 2);
                }

                funcion = "y = " + string.Format("{0:F4}", a1) + "* x + " + string.Format("{0:F4}", a0);
            }
            else if (cmbMetodo.SelectedIndex == 1)
            {
                double[,] matriz = GenerarMatrizPolinomial(int.Parse(txtGrado.Text), PuntosCargados);
                double[] gaussJordan = unidad2.GaussJordan(int.Parse(txtGrado.Text)+1, matriz);

                //Inicio armado funcion
                funcion = string.Empty;
                string signo = string.Empty;
                
                for (int i = 0; i < gaussJordan.Count();i++)
                {
                    double ai = Math.Round(gaussJordan[i],4);
                    if (i == 0 && ai!=0)
                    {
                        funcion = $"{ai}";
                    }
                    else if (i == 1 && ai!=0)
                    {
                        funcion = $"{ai}x {signo}" + funcion;
                    }
                    else
                    {
                        if (ai != 0)
                        {
                            funcion = $"{ai}x^{i} {signo}" + funcion;
                        }
                    }
                    signo = ai > 0 ? "+" : string.Empty;
                }
                //Fin de armado funcion
                //Calculamos St y Sr
                double x = 0;
                double y = 0;
                double sumaY = 0;
                foreach (double[] punto in PuntosCargados)
                {
                    sumaY += punto[1];
                }
                foreach (double[] punto in PuntosCargados)
                {
                    x = punto[0];
                    y = punto[1];
                    double suma = 0;
                    for (int i = 0;i < gaussJordan.Count();i++)
                    {
                        suma += gaussJordan[i] * Math.Pow(x, i);
                    }
                    Sr += Math.Pow(suma - y, 2);
                    St += Math.Pow(sumaY/puntosEntrada, 2);
                }
            }

            double r = Math.Sqrt((St - Sr) / St);

            //Mostrar
            if (r >= double.Parse(txtBoxTole.Text))
            {
                lblFResultado.Text = funcion;
                lblCorrelacionResultado.Text = string.Format("{0:F4}",(r * 100));
                lblEfectividadResultado.Text = "El ajuste es aceptable.";
                graficador.Graficar(PuntosCargados, funcion);
            }
            else
            {
                lblFResultado.Text = funcion;
                lblCorrelacionResultado.Text = string.Format("{0:F4}", r*100);
                lblEfectividadResultado.Text = "El ajuste no es aceptable.";
            }
        }

        //Fin unidad 3
        //Inicio unidad 4

        private void btnCalcularU4_Click(object sender, EventArgs e)
        {
            Unidad4 unidad4 = new Unidad4();
            double area = 0;
            switch (cmbMetodosU4.SelectedIndex)
            {
                case 0:
                    area = unidad4.CalcularIntegralTrapeciosSimple(txtFxU4.Text, double.Parse(txtXiU4.Text), 
                        double.Parse(txtXdU4.Text));
                    break;
                case 1:
                    area = unidad4.CalcularIntegralTrapeciosMultiples(txtFxU4.Text, double.Parse(txtXiU4.Text), 
                        double.Parse(txtXdU4.Text), int.Parse(txtCantInterU4.Text));
                    break;
                case 2:
                    area = unidad4.CalcularIntegralSimpson1_3Simple(txtFxU4.Text, double.Parse(txtXiU4.Text),
                        double.Parse(txtXdU4.Text));
                    break;
                case 3:
                    area = unidad4.CalcularIntegralSimpson1_3Multiple(txtFxU4.Text, double.Parse(txtXiU4.Text),
                        double.Parse(txtXdU4.Text), int.Parse(txtCantInterU4.Text));
                    break;
                case 4:
                    area = unidad4.CalcularIntegralSimpson3_8(txtFxU4.Text, double.Parse(txtXiU4.Text),
                        double.Parse(txtXdU4.Text));
                    break;
                case 5:
                    area = unidad4.CalcularIntegralSimpson1_3MultipleConImpar(txtFxU4.Text, double.Parse(txtXiU4.Text),
                        double.Parse(txtXdU4.Text), int.Parse(txtCantInterU4.Text));
                    break;
                    
            }
            if (area != double.NaN)
            {
                lblAreaResultadoU4.Text= string.Format("{0:F4}", area); 
            }
            else
            {
                lblAreaResultadoU4.Text = "Error";
            }
        }
    }
}
