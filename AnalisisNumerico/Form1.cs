using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;
using Analisis_Numerico;

namespace AnalisisNumerico
{
    public partial class AnalisisNumerico : Form
    {
        public Graficador graficador { get; set; }

        public AnalisisNumerico()
        {
            InitializeComponent();
            SetPanelGrafica();
        }

        private void SetPanelGrafica()
        {
            panelGrafica.Controls.Clear();
            this.graficador = new Graficador();
            panelGrafica.Controls.Add(graficador);
            graficador.Dock = DockStyle.Fill;
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

            if (panel1.Controls.Count != 0)
            {
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

        List<Points> PuntosCargados = new List<Points>();
        private void cargarBtn_Click(object sender, EventArgs e)
        {
            
            if (xResult.Text !="" && yResult.Text!="")
            {
                warnLabel.Text = "";
                Points puntoNuevo = new Points() { x = double.Parse(xResult.Text), y = double.Parse(yResult.Text) };
                PuntosCargados.Add(puntoNuevo);
                Label puntoIngresado = new Label();
                puntoIngresado.Text = puntoNuevo.ToString();
                int cantidadElementos = PuntosCargados.Count();
                int puntoY = (cantidadElementos - 1) * 17;
                puntoIngresado.Location = new Point(0, puntoY);
                puntoIngresado.Size = new Size(100, 16);
                puntoIngresado.Font = new Font("Arial", 11);
                panelPuntos.Controls.Add(puntoIngresado);
                panelPuntos.Show();
                xResult.Clear();
                yResult.Clear();

            } else
            {
                warnLabel.Text = "Debe ingresar un valor al punto";
            }
            
        }

        private void calcularRectaBtn_Click(object sender, EventArgs e)
        {
            int tolerancia = int.Parse(toleranciaValue.Text);
            string funcion = "";
            int cantidadPuntos = PuntosCargados.Count();
            double sumatoriaX = PuntosCargados.Sum(punto => punto.x);
            double sumatoriaY = PuntosCargados.Sum(punto => punto.y);
            double sumatoriaXY = PuntosCargados.Sum(punto => punto.x * punto.y);
            double sumatoriaX2 = PuntosCargados.Sum(punto => punto.x * punto.x);

            var a1 = (cantidadPuntos * sumatoriaXY - sumatoriaX * sumatoriaY) / (cantidadPuntos * sumatoriaX2 - (sumatoriaX * sumatoriaX));
            var a0 = (sumatoriaY / cantidadPuntos) - a1 * (sumatoriaX / cantidadPuntos);

            var st = PuntosCargados.Sum(punto => (sumatoriaY / cantidadPuntos - punto.y) * (sumatoriaY / cantidadPuntos - punto.y));
            var sr = PuntosCargados.Sum(punto => (a1 * punto.x + a0 - punto.y) * (a1 * punto.x + a0 - punto.y));

            List<double[]> puntos = new List<double[]>();
            foreach (var punto in PuntosCargados)
            {
                puntos.Add(new double[] { punto.x, punto.y });
            }

            switch (metodoCombobox.SelectedIndex)
            {
                case 0:
                    //Regresión Lineal
                    var r = Math.Sqrt((st - sr) / st) * 100;
                    funcion = Math.Round(a1, 3).ToString() + "*x" + " + " + Math.Round(a0, 3).ToString();

                    graficador.Graficar(puntos, funcion);

                    funcionRes.Text = funcion;
                    correlacionResult.Text = Math.Round(r, 2).ToString() + "%";
                    efectividadRes.Text = r < tolerancia ? "El ajuste no es aceptable." : "El ajuste es aceptable.";

                    break;
                case 1:
                    //Regresión Polinomial
                    st = 0; sr = 0;
                    int grado = int.Parse(gradoValue.Text);
                    double[,] resultado = GaussJordan(grado + 1, GenerarMatrizPolinomial(grado, PuntosCargados));
                    var longitudVectorResultado = resultado.GetLength(0);
                    double[] vectorResultado = new double[longitudVectorResultado];
                    for (int i = 0; i < longitudVectorResultado; i++)
                    {
                        vectorResultado[i] = resultado[i, resultado.GetLength(1)-1];
                    }

                    funcion = "";
                    string signo = "";
                    for (int i = 0; i < vectorResultado.Count(); i++)
                    {
                        double ai = Math.Round(vectorResultado[i], 4);
                        if(i==0 && ai != 0)
                        {
                            funcion = $"{ai}";
                        } 
                        else if(i == 1 && ai != 0)
                        {
                            funcion = $"{ai}x {signo}" + funcion;
                        } 
                        else if (ai != 0)
                        {
                            funcion = $"{ai}x^{i} {signo}" + funcion;
                        }
                        signo = ai > 0 ? "+" : "";
                    }

                    double x = 0;
                    double y = 0;
                    foreach (var punto in PuntosCargados)
                    {
                        x = punto.x;
                        y = punto.y;
                        double suma = 0;
                        for (int i = 0; i < vectorResultado.Count(); i++)
                        {
                            suma += vectorResultado[i] * Math.Pow(x, i);
                        }
                        sr += Math.Pow(suma - y, 2);
                        st += Math.Pow(sumatoriaY/cantidadPuntos - y, 2);
                    }

                    graficador.Graficar(puntos, funcion);
                    var rel = Math.Sqrt((st - sr) / st) * 100;
                    funcionRes.Text = funcion;
                    correlacionResult.Text = Math.Round(rel, 2).ToString() + "%";
                    efectividadRes.Text = rel < tolerancia ? "El ajuste no es aceptable." : "El ajuste es aceptable.";

                    break;
                default:
                    break;
            }
        }

        private double[,] GenerarMatrizPolinomial(int grado, List<Points>puntosCargados)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension+1];
            double x = 0;
            double y = 0;
            foreach (var punto in puntosCargados)
            {
                x = punto.x;
                y = punto.y;
                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int columna = 0; columna < dimension; columna++)
                    {
                        matriz[fila, columna] += Math.Pow(x, fila + columna);
                    }
                    matriz[fila, dimension] += y * Math.Pow(x, fila);
                }
            }
            return matriz;
        }

        private void borrarPuntosBtn_Click(object sender, EventArgs e)
        {
            PuntosCargados.Clear();
            panelPuntos.Controls.Clear();
            funcionRes.Text = "--";
            correlacionResult.Text = "--";
            efectividadRes.Text = "--";
        }

        private void borrarUltimoBtn_Click(object sender, EventArgs e)
        {
            PuntosCargados.Remove(PuntosCargados[PuntosCargados.Count() - 1]);
            panelPuntos.Controls.RemoveAt(panelPuntos.Controls.Count - 1);
            panelPuntos.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculo analizadorFunciones = new Calculo();
            string fx = funcionINvalue.Text;
            analizadorFunciones.Sintaxis(fx, 'x');

            double a = double.Parse(intervaloA.Text);
            double b = double.Parse(intervaloB.Text);
            int n = 0;
            double h = 0;
            double resultado = 0;
            double sumatoria = 0;
            double sumatoria2 = 0;
            switch (metodoIN.SelectedIndex)
            {
                //Trapecios simple
                case 0:
                    resultado = ((analizadorFunciones.EvaluaFx(a) + analizadorFunciones.EvaluaFx(b)) * (b - a)) / 2;
                    resultadoU4.Text = Math.Round(resultado, 3).ToString();
                    break;
                //Trapecios multiple
                case 1:
                    n = int.Parse(cantidadSubintervalos.Text);
                    h = (b - a) / n;

                    for (int i = 1; i < n; i++)
                    {
                        sumatoria += analizadorFunciones.EvaluaFx(a+h*i);
                    }

                    resultado = ((h / 2) * (analizadorFunciones.EvaluaFx(a) + 2 * sumatoria + analizadorFunciones.EvaluaFx(b)));
                    resultadoU4.Text = Math.Round(resultado,3).ToString();
                    break;
                //Simpson 1/3 simple
                case 2:
                    h = ((b - a) / 2);
                    resultado = ((h / 3) * (analizadorFunciones.EvaluaFx(a) + 4 * analizadorFunciones.EvaluaFx(a + h) + analizadorFunciones.EvaluaFx(b)));
                    resultadoU4.Text = Math.Round(resultado, 3).ToString();
                    break;
                //Simpson 1/3 Multiple
                case 3:
                    n = int.Parse(cantidadSubintervalos.Text);
                    if (n%2 == 0)
                    {
                        h = ((b - a) / n);

                        for (int i = 1; i < n; i+=2)
                        {
                            sumatoria += analizadorFunciones.EvaluaFx(a + h * i);
                        }

                        for (int i = 2; i < n-1; i+=2)
                        {
                            sumatoria2 += analizadorFunciones.EvaluaFx(a + h * i);
                        }

                        resultado = ((h / 3) * (analizadorFunciones.EvaluaFx(a) + 4 * sumatoria + 2 * sumatoria2 + analizadorFunciones.EvaluaFx(b)));

                    } else
                    {
                        h = (b - a) / 3;
                        resultado = (((3*h)/8) * (analizadorFunciones.EvaluaFx(a) + 3 * analizadorFunciones.EvaluaFx(a+h) + 3* analizadorFunciones.EvaluaFx(a+2*h)+ analizadorFunciones.EvaluaFx(b)));
                    }
                    resultadoU4.Text = Math.Round(resultado, 3).ToString();
                    break;
            }
        }
    }

    class Points
    {
        public double x { get; set; }
        public double y { get; set; }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }


}
