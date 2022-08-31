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

namespace BISECCION
{
    public partial class Form1 : Form
    {
        public Form1()
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
                if(xiValue.Text == "" || xdValue.Text == "")
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
                            double xr = (xi + xd)/2;
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
                                    if (AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xd) < 0)
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
                if (AnalizadorDeFunciones.EvaluaFx(xini) < double.Parse(toleValue.Text))
                    raizResult.Text = xini.ToString();
                else
                {
                    aumentar:
                    contador++;
                    var DERIF = AnalizadorDeFunciones.Dx(xini);
                    if(DERIF == 0)
                        warningLabel.Text = "Fx'(xini) = 0. Error por división por cero!.";
                    else
                    {
                        double xr = xini - (AnalizadorDeFunciones.EvaluaFx(xini) / DERIF);
                        if(xr == 0)
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
                if (AnalizadorDeFunciones.EvaluaFx(xini) < double.Parse(toleValue.Text))
                    raizResult.Text = xini.ToString();
                else
                {
                    aumentar:
                    contador++;
                    var DERIF = AnalizadorDeFunciones.Dx(xini);
                    var divisorxr = AnalizadorDeFunciones.EvaluaFx(xini2) - AnalizadorDeFunciones.EvaluaFx(xini);
                    if(divisorxr == 0)
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
                                goto aumentar;
                            }
                        }
                    }
                }
            }
            else
                warningLabel.Text = "Ingresa todos los valores antes de ingresar la f(x)";
        }
    }
}
