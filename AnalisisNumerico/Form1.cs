﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace AnalisisNumerico
{
    public partial class AnalisisNumerico : Form
    {
        public AnalisisNumerico()
        {
            InitializeComponent();



        }

        private void biseccionBtn_Click(object sender, EventArgs e)
        {
            if (functionInput.Text != "" && xiValue.Text != "" && xdValue.Text != "" && toleValue.Text != "" && iterValue.Text != "")
            {
                warningLabel.Text = "";
                Calculo AnalizadorDeFunciones = new Calculo();
                string fx = functionInput.Text;
                AnalizadorDeFunciones.Sintaxis(fx, 'x');
                evaluar:
                if (xiValue.Text == "" || xdValue.Text == "")
                    MessageBox.Show("Ingrese nuevos valores para xi y xd");
                else
                {
                    double xi = double.Parse(xiValue.Text);
                    double xd = double.Parse(xdValue.Text);
                    double valor = AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xd);
                    switch (valor)
                    {
                        case var _ when valor > 0:
                            xiValue.Text = "";
                            xdValue.Text = "";
                            goto evaluar;
                        case var _ when valor < 0:
                            double xant = 0;
                            int contador = 0;
                        aumentar:
                            contador++;
                            double xr = (xi + xd) / 2;
                            double error = Math.Abs((xr - xant) / xr);
                            if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr)) < double.Parse(toleValue.Text) || error < double.Parse(toleValue.Text) || contador > int.Parse(iterValue.Text))
                            {
                                if (contador >= int.Parse(iterValue.Text))
                                    convergeResult.Text = "No";
                                else
                                    convergeResult.Text = "Sí";

                                raizResult.Text = xr.ToString();
                                iterResult.Text = contador.ToString();
                                errorResult.Text = error.ToString();
                                break;
                            }
                            else
                                if (AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xr) < 0)
                                xd = xr;
                            else
                                xi = xr;
                            xant = xr;
                            goto aumentar;
                        case 0:
                            if (AnalizadorDeFunciones.EvaluaFx(xi) == 0)
                                raizResult.Text = xi.ToString();
                            else
                                raizResult.Text = xd.ToString();
                            break;
                    }
                }
            }
            else
                warningLabel.Text = "Ingresa todos los valores antes de ingresar la f(x)";
        }

        private void reglafalsaBtn_Click(object sender, EventArgs e)
        {
            if (functionInput.Text != "" && xiValue.Text != "" && xdValue.Text != "" && toleValue.Text != "" && iterValue.Text != "")
            {
                warningLabel.Text = "";
                Calculo AnalizadorDeFunciones = new Calculo();
                string fx = functionInput.Text;
                AnalizadorDeFunciones.Sintaxis(fx, 'x');
            evaluar:
                if (xiValue.Text == "" || xdValue.Text == "")
                    MessageBox.Show("Ingrese nuevos valores para xi y xd");
                else
                {
                    double xi = double.Parse(xiValue.Text);
                    double xd = double.Parse(xdValue.Text);
                    double valor = AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xd);
                    switch (valor)
                    {
                        case var _ when valor > 0:
                            xiValue.Text = "";
                            xdValue.Text = "";
                            goto evaluar;
                        case var _ when valor < 0:
                            double xant = 0;
                            int contador = 0;
                        aumentar:
                            contador++;
                            var divisorXr = AnalizadorDeFunciones.EvaluaFx(xi) - AnalizadorDeFunciones.EvaluaFx(xd);
                            if (divisorXr == 0)
                                goto evaluar;
                            else
                            {
                                double xr = (AnalizadorDeFunciones.EvaluaFx(xi) * xd - AnalizadorDeFunciones.EvaluaFx(xd) * xi) / divisorXr;
                                double error = Math.Abs((xr - xant) / xr);
                                if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr)) < double.Parse(toleValue.Text) || error < double.Parse(toleValue.Text) || contador > int.Parse(iterValue.Text))
                                {
                                    if (contador >= int.Parse(iterValue.Text))
                                        convergeResult.Text = "No";
                                    else
                                        convergeResult.Text = "Sí";

                                    raizResult.Text = xr.ToString();
                                    iterResult.Text = contador.ToString();
                                    errorResult.Text = error.ToString();
                                    break;
                                }
                                else
                                    if (AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xr) < 0)
                                    xd = xr;
                                else
                                    xi = xr;
                                xant = xr;
                                goto aumentar;
                            }
                        case 0:
                            if (AnalizadorDeFunciones.EvaluaFx(xi) == 0)
                                raizResult.Text = xi.ToString();
                            else
                                raizResult.Text = xd.ToString();
                            break;
                    }
                }
            }
            else
                warningLabel.Text = "Ingresa todos los valores antes de ingresar la f(x)";
        }

        private void newtonBtn_Click(object sender, EventArgs e)
        {
            if (functionInput.Text != "" && toleValue.Text != "" && iterValue.Text != "")
            {
                warningLabel.Text = "";
                Calculo AnalizadorDeFunciones = new Calculo();
                string fx = functionInput.Text;
                AnalizadorDeFunciones.Sintaxis(fx, 'x');
                double xant = 0;
                int contador = 0;
                double xini = double.Parse(xiValue.Text);
                if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xini)) < double.Parse(toleValue.Text))
                    raizResult.Text = xini.ToString();
                else
                {
                aumentar:
                    contador++;
                    var DERIF = AnalizadorDeFunciones.Dx(xini);
                    if (DERIF == 0)
                        warningLabel.Text = "Fx'(xini) = 0. Error por división por cero!.";
                    else
                    {
                        double xr = xini - (AnalizadorDeFunciones.EvaluaFx(xini) / DERIF);
                        if (xr == 0)
                            warningLabel.Text = "xr = 0. Error por división por cero!.";
                        else
                        {
                            double error = Math.Abs((xr - xant) / xr);
                            var fxr = Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr));
                            var tole = double.Parse(toleValue.Text);
                            if (fxr < tole || error < double.Parse(toleValue.Text) || contador > int.Parse(iterValue.Text))
                            {
                                if (contador >= int.Parse(iterValue.Text))
                                    convergeResult.Text = "No";
                                else
                                    convergeResult.Text = "Sí";

                                raizResult.Text = xr.ToString();
                                iterResult.Text = contador.ToString();
                                errorResult.Text = error.ToString();
                            }
                            else
                            {
                                xant = xr;
                                xini = xr;
                                goto aumentar;
                            }
                        }
                    }
                }
            }
            else
                warningLabel.Text = "Ingresa todos los valores antes de ingresar la f(x)";
        }

        private void secanteBtn_Click(object sender, EventArgs e)
        {
            if (functionInput.Text != "" && toleValue.Text != "" && iterValue.Text != "")
            {
                warningLabel.Text = "";
                Calculo AnalizadorDeFunciones = new Calculo();
                string fx = functionInput.Text;
                AnalizadorDeFunciones.Sintaxis(fx, 'x');
                double xant = 0;
                int contador = 0;
                double xini = double.Parse(xiValue.Text);
                double xini2 = double.Parse(xdValue.Text);
                if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xini)) < double.Parse(toleValue.Text))
                    raizResult.Text = xini.ToString();
                else
                {
                aumentar:
                    contador++;
                    var divisorxr = AnalizadorDeFunciones.EvaluaFx(xini2) - AnalizadorDeFunciones.EvaluaFx(xini);
                    if (divisorxr == 0)
                        warningLabel.Text = "F(xini2) - F(xini) = 0. Error por división por cero!.";
                    else
                    {
                        double xr = (AnalizadorDeFunciones.EvaluaFx(xini2) * xini - AnalizadorDeFunciones.EvaluaFx(xini) * xini2) / divisorxr;
                        if (xr == 0)
                            warningLabel.Text = "xr = 0. Error por división por cero!.";
                        else
                        {
                            double error = Math.Abs((xr - xant) / xr);
                            var fxr = Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr));
                            var tole = double.Parse(toleValue.Text);
                            if (fxr < tole || error < double.Parse(toleValue.Text) || contador > int.Parse(iterValue.Text))
                            {
                                if (contador >= int.Parse(iterValue.Text))
                                    convergeResult.Text = "No";
                                else
                                    convergeResult.Text = "Sí";

                                raizResult.Text = xr.ToString();
                                iterResult.Text = contador.ToString();
                                errorResult.Text = error.ToString();
                            }
                            else
                            {
                                xini = xini2;
                                xini2 = xr;
                                xant = xr;
                                goto aumentar;
                            }
                        }
                    }
                }
            }
            else
                warningLabel.Text = "Ingresa todos los valores antes de ingresar la f(x)";
        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int dimension = int.Parse(dimensionValue.Text);
                int pointX = 30;
                int pointY = 30;
                panel1.Controls.Clear();
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension+1; col++)
                    {
                        string nombre = $"({row.ToString()},{col.ToString()})";
                        TextBox b = new TextBox();
                        b.Name = nombre;
                        b.Size = new System.Drawing.Size(100, 100);
                        pointX += 120;
                        b.Location = new Point(pointX, pointY);
                        panel1.Controls.Add(b);
                        panel1.Show();
                    }
                    pointX = 30;
                    pointY += 30;

                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private double[,] GuardarMatriz(int dimension)
        {
            double[,] matriz = new double[dimension, dimension+1];
            for (int col = 0; col < dimension+1; col++)
            {
                for (int row = 0; row < dimension; row++)
                {
                    Control textBox = panel1.Controls.Find($"({row.ToString()},{col.ToString()})", true).First();
                    matriz[row, col] = double.Parse((textBox as TextBox).Text);
                }
            }
            return matriz;
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            int dimension = int.Parse(dimensionValue.Text);
            double[,] matriz = GuardarMatriz(dimension);
            switch (tipoCombobox.SelectedIndex)
            {
                case 0:
                    //metodo Gauss Jordan
                    GaussJordan(dimension, matriz);
                    break;

                case 1:
                    //metodo Gauss Seidel
                    GaussSeidel(dimension, matriz);
                    break;

                default:
                    break;
            }

        }

        public double[,] GaussJordan(int dimension, double[,] matriz)
        {
            double coeficienteP = 0;
            int column = 0;
            for (int rowDiag = 0; rowDiag < dimension; rowDiag++)
            {
                for (int col = 0; col < dimension+1; col++)
                {
                    if(rowDiag == col)
                    {
                        coeficienteP = matriz[rowDiag, col];
                    }
                    matriz[rowDiag,col] = matriz[rowDiag, col] / coeficienteP;
                }

                for (int row = 0; row < dimension; row++)
                {
                    if (rowDiag != row)
                    {
                        var coeficiente = matriz[row, column];
                        for (int columna = 0; columna <= dimension; columna++)
                        {
                            matriz[row, columna] = matriz[row, columna] - (coeficiente * matriz[rowDiag, columna]);
                        }
                    }
                }
                column++;
            }

            int contador = 0;
            for (int rowResultado = 0; rowResultado < dimension; rowResultado++)
            {
                for (int colResultado = 0; colResultado < dimension+1; colResultado++)
                {
                    Control textBox = panel1.Controls[contador];
                    textBox.Text = matriz[rowResultado, colResultado].ToString();
                    contador++;
                }
            }

            return matriz;
        }

        public double[] GaussSeidel(int dimension, double[,] matriz)
        {
            double tolerancia = 0.0001;
            bool menorTolerancia = false;
            int contador = 0;
            double[] vectorResultado = new double[dimension];
            vectorResultado.Initialize();
            double[] vectorAnterior = new double[dimension];

            while (contador <= 100 && !menorTolerancia)
            {
                contador++;
                if (contador>1)
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }

                for (int row = 0; row < dimension; row++)
                {
                    var resultado = matriz[row, dimension];
                    var coeficienteIncognita = matriz[row, row];

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

            iteracResult.Text = contador.ToString();

            resultadoSeidel.Text = "";
            for (int i = 0; i < vectorResultado.Length; i++)
            {
                resultadoSeidel.Text += "X"+ (i+1).ToString() + " = " + Math.Round(vectorResultado[i],5).ToString() + "\n";
            }

            if (contador <= 100)
            {
                return vectorResultado;
            } else {
                resultadoSeidel.Text = "El programa superó las iteraciones limite por lo tanto es divergente.";
                return null;
            }

        }

        private void cargarBtn_Click(object sender, EventArgs e)
        {
            List<double[]> PuntosCargados = new List<double[]>();
            
        }

        private void calcularRectaBtn_Click(object sender, EventArgs e)
        {
            switch (metodoCombobox.SelectedIndex)
            {
                case 0:
                    //Regresión Lineal
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }
    }
}