
namespace IMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblPesoAtual = new System.Windows.Forms.Label();
            this.LblImc = new System.Windows.Forms.Label();
            this.LblCassificacao = new System.Windows.Forms.Label();
            this.LblObesidade = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtImc = new System.Windows.Forms.TextBox();
            this.TxtClassificacao = new System.Windows.Forms.TextBox();
            this.TxtObesidade = new System.Windows.Forms.TextBox();
            this.MskAltura = new System.Windows.Forms.MaskedTextBox();
            this.MskPeso = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(72, 34);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(39, 15);
            this.LblAltura.TabIndex = 0;
            this.LblAltura.Text = "Altura";
            // 
            // LblPesoAtual
            // 
            this.LblPesoAtual.AutoSize = true;
            this.LblPesoAtual.Location = new System.Drawing.Point(50, 73);
            this.LblPesoAtual.Name = "LblPesoAtual";
            this.LblPesoAtual.Size = new System.Drawing.Size(61, 15);
            this.LblPesoAtual.TabIndex = 1;
            this.LblPesoAtual.Text = "Peso atual";
            // 
            // LblImc
            // 
            this.LblImc.AutoSize = true;
            this.LblImc.Location = new System.Drawing.Point(82, 187);
            this.LblImc.Name = "LblImc";
            this.LblImc.Size = new System.Drawing.Size(29, 15);
            this.LblImc.TabIndex = 2;
            this.LblImc.Text = "IMC";
            // 
            // LblCassificacao
            // 
            this.LblCassificacao.AutoSize = true;
            this.LblCassificacao.Location = new System.Drawing.Point(36, 219);
            this.LblCassificacao.Name = "LblCassificacao";
            this.LblCassificacao.Size = new System.Drawing.Size(75, 15);
            this.LblCassificacao.TabIndex = 3;
            this.LblCassificacao.Text = "Classificação";
            // 
            // LblObesidade
            // 
            this.LblObesidade.AutoSize = true;
            this.LblObesidade.Location = new System.Drawing.Point(12, 253);
            this.LblObesidade.Name = "LblObesidade";
            this.LblObesidade.Size = new System.Drawing.Size(99, 15);
            this.LblObesidade.TabIndex = 4;
            this.LblObesidade.Text = "Obesidade (Grau)";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(12, 344);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(93, 344);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(174, 344);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 9;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // TxtImc
            // 
            this.TxtImc.Location = new System.Drawing.Point(117, 184);
            this.TxtImc.Name = "TxtImc";
            this.TxtImc.ReadOnly = true;
            this.TxtImc.Size = new System.Drawing.Size(100, 23);
            this.TxtImc.TabIndex = 11;
            // 
            // TxtClassificacao
            // 
            this.TxtClassificacao.Location = new System.Drawing.Point(117, 216);
            this.TxtClassificacao.Name = "TxtClassificacao";
            this.TxtClassificacao.ReadOnly = true;
            this.TxtClassificacao.Size = new System.Drawing.Size(100, 23);
            this.TxtClassificacao.TabIndex = 12;
            // 
            // TxtObesidade
            // 
            this.TxtObesidade.Location = new System.Drawing.Point(117, 250);
            this.TxtObesidade.Name = "TxtObesidade";
            this.TxtObesidade.ReadOnly = true;
            this.TxtObesidade.Size = new System.Drawing.Size(100, 23);
            this.TxtObesidade.TabIndex = 13;
            // 
            // MskAltura
            // 
            this.MskAltura.Location = new System.Drawing.Point(122, 31);
            this.MskAltura.Mask = "#.##";
            this.MskAltura.Name = "MskAltura";
            this.MskAltura.Size = new System.Drawing.Size(100, 23);
            this.MskAltura.TabIndex = 14;
            // 
            // MskPeso
            // 
            this.MskPeso.Location = new System.Drawing.Point(122, 70);
            this.MskPeso.Mask = "###.##";
            this.MskPeso.Name = "MskPeso";
            this.MskPeso.Size = new System.Drawing.Size(100, 23);
            this.MskPeso.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 381);
            this.Controls.Add(this.MskPeso);
            this.Controls.Add(this.MskAltura);
            this.Controls.Add(this.TxtObesidade);
            this.Controls.Add(this.TxtClassificacao);
            this.Controls.Add(this.TxtImc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.LblObesidade);
            this.Controls.Add(this.LblCassificacao);
            this.Controls.Add(this.LblImc);
            this.Controls.Add(this.LblPesoAtual);
            this.Controls.Add(this.LblAltura);
            this.Name = "Form1";
            this.Text = "Cálculo de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblPesoAtual;
        private System.Windows.Forms.Label LblImc;
        private System.Windows.Forms.Label LblCassificacao;
        private System.Windows.Forms.Label LblObesidade;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtImc;
        private System.Windows.Forms.TextBox TxtClassificacao;
        private System.Windows.Forms.TextBox TxtObesidade;
        private System.Windows.Forms.MaskedTextBox MskAltura;
        private System.Windows.Forms.MaskedTextBox MskPeso;
    }
}

