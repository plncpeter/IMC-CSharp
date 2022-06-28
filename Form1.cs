using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNome2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variaveis p/ armazenar os valores 
            double peso = 0;
            double altura = 0;
            double imc = 0;
            if (txbN1.Text != "" && txbN2.Text != "")
            {
                peso = double.Parse(txbN1.Text);
                altura = double.Parse(txbN2.Text);
            }
                
           
            // Fazer a operação:
            imc = peso / (altura * altura);

            // Mostrar o valor no lblResult:
            lblResultado.Text = imc.ToString();

            //Mostrar sua situação:
            if (double.Parse(lblResultado.Text) <= 18.5)
            {
                lblConfirmacao.Text = "Abaixo do peso";
                lblConfirmacao.ForeColor = Color.Red;
            }
            else if (double.Parse(lblResultado.Text) >= 18.6 && (double.Parse(lblResultado.Text) <= 24.9))
            {
                lblConfirmacao.Text = "Peso Ideal";
                lblConfirmacao.ForeColor = Color.Green;
            }
            else if (double.Parse(lblResultado.Text) >= 25 && (double.Parse(lblResultado.Text) <= 29.9))
            {
                lblConfirmacao.Text = "Levemente acima do peso";
                lblConfirmacao.ForeColor = Color.Yellow;
            }
            else if (double.Parse(lblResultado.Text) >= 30 && (double.Parse(lblResultado.Text) <= 34.9))
            {
                lblConfirmacao.Text = "Obesidade Grau 1";
                lblConfirmacao.ForeColor = Color.Red;
            }
            else if (double.Parse(lblResultado.Text) >= 35 && (double.Parse(lblResultado.Text) <= 39.9))
            {
                lblConfirmacao.Text = "Obesidade Grau 2";
                lblConfirmacao.ForeColor = Color.Red;
            }
            else if (double.Parse(lblResultado.Text) >= 40)
            {
                lblConfirmacao.Text = "Obesidade Grau 3";
                lblConfirmacao.ForeColor = Color.Red;
            }
            else
            {
                lblConfirmacao.Text = "Verifique os dados";
                lblConfirmacao.ForeColor = Color.Chocolate;
            }
        }
    }
}
