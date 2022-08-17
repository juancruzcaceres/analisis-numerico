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

        private void functionInput_TextChanged(object sender, EventArgs e)
        {
            if( xiValue.Text != "" && xdValue.Text != "" && toleValue.Text != "" && iterValue.Text != "")
            {
                Calculo AnalizadorDeFunciones = new Calculo();
                string fx = functionInput.Text;
                AnalizadorDeFunciones.Sintaxis(fx, 'x');
                evaluar:
                double xi = double.Parse(xiValue.Text);
                double xd = double.Parse(xdValue.Text);
                double valor = AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xi);
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
                        double xr = (xd + xi) / 2;
                        double error = Math.Abs((xr - xant) / xr);
                        if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr)) < double.Parse(toleValue.Text) || error < double.Parse(toleValue.Text) || contador >= int.Parse(iterValue.Text))
                            raizResult.Text = xr.ToString();
                        else
                            if (AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xd) < 0)
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
            else
            {
                warningLabel.Text = "Ingresa todos los valores antes de ingresar la f(x)";
            }

            
        }
    }
}
