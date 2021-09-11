using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void CheckValues()
        {
            double ladoA;
            double ladoB;
            double ladoC;
            bool ladoAIsDouble = Double.TryParse(TxtLadoA.Text, out ladoA);
            bool ladoBIsDouble = Double.TryParse(TxtLadoB.Text, out ladoB);
            bool ladoCIsDouble = Double.TryParse(TxtLadoC.Text, out ladoC);

            if (string.IsNullOrWhiteSpace(TxtLadoA.Text) && !ladoAIsDouble ||
                string.IsNullOrWhiteSpace(TxtLadoB.Text) && !ladoBIsDouble ||
                string.IsNullOrWhiteSpace(TxtLadoC.Text) && !ladoCIsDouble)
            {
                BtnVerificar.Enabled = false;
            }
            else
            {
                BtnVerificar.Enabled = true;
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtLadoA.Text = null;
            TxtLadoB.Text = null;
            TxtLadoC.Text = null;
            TxtResultado.Text = null;
            CheckValues();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(TxtLadoA.Text); 
            double ladoB = double.Parse(TxtLadoB.Text); 
            double ladoC = double.Parse(TxtLadoC.Text);

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB)) {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    TxtResultado.Text = "Equilátero";
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    TxtResultado.Text = "Isóceles";
                }
                else
                {
                    TxtResultado.Text = "Escaleno";
                }
            } else
            {
                TxtResultado.Text = "Não é um triângulo";
            }
        }

        private void TxtLadoA_Validating(object sender, CancelEventArgs e)
        {
            double ladoA;
            bool isDouble = Double.TryParse(TxtLadoA.Text, out ladoA);
            if (string.IsNullOrWhiteSpace(TxtLadoA.Text) || !isDouble)
            {
                e.Cancel = true;
                TxtLadoA.Focus();
                errorProvider1.SetError(TxtLadoA, "Insira um número!");
                BtnVerificar.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtLadoA, "");
                CheckValues();
            }

        }

        private void TxtLadoB_Validating(object sender, CancelEventArgs e)
        {
            double ladoB;
            bool isDouble = Double.TryParse(TxtLadoB.Text, out ladoB);
            if (string.IsNullOrWhiteSpace(TxtLadoB.Text) || !isDouble)
            {
                e.Cancel = true;
                TxtLadoB.Focus();
                errorProvider2.SetError(TxtLadoB, "Insira um número!");
                BtnVerificar.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(TxtLadoB, "");
                CheckValues();
            }

        }

        private void TxtLadoC_Validating(object sender, CancelEventArgs e)
        {
            double ladoC;
            bool isDouble = Double.TryParse(TxtLadoC.Text, out ladoC);
            if (string.IsNullOrWhiteSpace(TxtLadoC.Text) || !isDouble)
            {
                e.Cancel = true;
                TxtLadoC.Focus();
                errorProvider3.SetError(TxtLadoC, "Insira um número!");
                BtnVerificar.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(TxtLadoC, "");
                CheckValues();
            }
        }
    }
}
