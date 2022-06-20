using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public enum Operacion
    {
        NoDefinica=0,
        Suma =1,
        Resta =2,
        Division =3,
        Multiplicacion =4,
        
    }
    public partial class Form1 : Form
    {
        
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinica;
        bool unNumeroLeido = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero(String numero)
        {
            unNumeroLeido = true;
            if (txtResultado.Text == "0" && txtResultado.Text != null)
            {
                txtResultado.Text = numero;
            }
            else
            {

                txtResultado.Text += numero;
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.NoDefinica:
                    break;
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        // MessageBox.Show("No se puede dividir entre 0");
                        lbHistorial.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    resultado = valor1 / valor2;
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDouble(txtResultado.Text);
                lbHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                
                txtResultado.Text = Convert.ToString(resultado);
            }
        }
    

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }


        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if (txtResultado.Text == "0" )
                    {
                return;
            }
            else

            {

                txtResultado.Text += "0";

            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

            LeerNumero("6");

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }
        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(txtResultado.Text);
            lbHistorial.Text = txtResultado.Text + operador;
            txtResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Contains("."))
                
            {
                return;
            }

            txtResultado.Text += ".";
           
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lbHistorial.Text = "";
        }
    }
}
