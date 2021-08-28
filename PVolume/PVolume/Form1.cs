using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Aplication : Form
    {
        public Aplication()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double raio = Double.Parse(TxtRaio.Text);
            double altura = Double.Parse(TxtAltura.Text);
            double resultado = pi * (raio * raio) * altura;

            TxtVolume.Text = resultado.ToString("F");
        }

        private void TxtRaio_Validating(object sender, CancelEventArgs e)
        {
            double raio;
            bool isDouble = Double.TryParse(TxtRaio.Text, out raio);
            if (string.IsNullOrWhiteSpace(TxtRaio.Text) || !isDouble )
            {
                e.Cancel = true;
                TxtRaio.Focus();
                errorProviderApp.SetError(TxtRaio, "Insira um número!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(TxtRaio, "");
            }
        }

        private void TxtAltura_Validating(object sender, CancelEventArgs e)
        {
            double altura;
            bool isDouble = Double.TryParse(TxtRaio.Text, out altura);
            if (string.IsNullOrWhiteSpace(TxtRaio.Text) || !isDouble)
            {
                e.Cancel = true;
                TxtRaio.Focus();
                errorProviderApp.SetError(TxtRaio, "Insira um número!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(TxtRaio, "");
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtAltura.Clear();
            TxtRaio.Clear();
            TxtVolume.Clear();
        }
    }
}
