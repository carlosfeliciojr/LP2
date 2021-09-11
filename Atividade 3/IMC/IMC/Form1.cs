using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            MskPeso.Text = null;
            MskAltura.Text = null;
            TxtImc.Text = null;
            TxtClassificacao.Text = null;
            TxtObesidade.Text = null;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0;
            double altura = 0;
            bool pesoEValido = double.TryParse(MskPeso.Text, out peso);
            bool alturaEValida = double.TryParse(MskAltura.Text, out altura);

            double imc = 0;


            if (pesoEValido == true && alturaEValida == true)
            {
                imc = peso / Math.Pow(altura, 2);
            }

            if (imc < 18.5)
            {
                TxtImc.Text = "Menor que 18.5";
                TxtClassificacao.Text = "Magreza";
                TxtObesidade.Text = "O";
                return;
            } else if (imc < 25)
            {
                TxtImc.Text = "Entre 18.5 e 24.9";
                TxtClassificacao.Text = "Normal";
                TxtObesidade.Text = "O";
                return;
            } else if(imc < 30)
            {
                TxtImc.Text = "Entre 25 e 29.9";
                TxtClassificacao.Text = "Sobrepeso";
                TxtObesidade.Text = "I";
                return;
            }
            else if (imc < 40)
            {
                TxtImc.Text = "Entre 30 e 39.9";
                TxtClassificacao.Text = "Obesidade";
                TxtObesidade.Text = "II";
                return;
            } else
            {
                TxtImc.Text = "Maior que 40";
                TxtClassificacao.Text = "Obesidade Grave";
                TxtObesidade.Text = "III";
                return;
            }
        }
    }
}
