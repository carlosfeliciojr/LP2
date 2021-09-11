
namespace Triangulos
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
            this.components = new System.ComponentModel.Container();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.LblLadoB = new System.Windows.Forms.Label();
            this.LblLadoC = new System.Windows.Forms.Label();
            this.TxtLadoA = new System.Windows.Forms.TextBox();
            this.TxtLadoB = new System.Windows.Forms.TextBox();
            this.TxtLadoC = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(73, 42);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(44, 15);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Lado A";
            // 
            // LblLadoB
            // 
            this.LblLadoB.AutoSize = true;
            this.LblLadoB.Location = new System.Drawing.Point(73, 79);
            this.LblLadoB.Name = "LblLadoB";
            this.LblLadoB.Size = new System.Drawing.Size(43, 15);
            this.LblLadoB.TabIndex = 1;
            this.LblLadoB.Text = "Lado B";
            // 
            // LblLadoC
            // 
            this.LblLadoC.AutoSize = true;
            this.LblLadoC.Location = new System.Drawing.Point(73, 119);
            this.LblLadoC.Name = "LblLadoC";
            this.LblLadoC.Size = new System.Drawing.Size(44, 15);
            this.LblLadoC.TabIndex = 2;
            this.LblLadoC.Text = "Lado C";
            // 
            // TxtLadoA
            // 
            this.TxtLadoA.Location = new System.Drawing.Point(133, 39);
            this.TxtLadoA.Name = "TxtLadoA";
            this.TxtLadoA.Size = new System.Drawing.Size(100, 23);
            this.TxtLadoA.TabIndex = 3;
            this.TxtLadoA.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLadoA_Validating);
            // 
            // TxtLadoB
            // 
            this.TxtLadoB.Location = new System.Drawing.Point(133, 76);
            this.TxtLadoB.Name = "TxtLadoB";
            this.TxtLadoB.Size = new System.Drawing.Size(100, 23);
            this.TxtLadoB.TabIndex = 4;
            this.TxtLadoB.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLadoB_Validating);
            // 
            // TxtLadoC
            // 
            this.TxtLadoC.Location = new System.Drawing.Point(133, 116);
            this.TxtLadoC.Name = "TxtLadoC";
            this.TxtLadoC.Size = new System.Drawing.Size(100, 23);
            this.TxtLadoC.TabIndex = 5;
            this.TxtLadoC.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLadoC_Validating);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(48, 189);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(59, 15);
            this.LblResultado.TabIndex = 6;
            this.LblResultado.Text = "Resultado";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(123, 186);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(153, 23);
            this.TxtResultado.TabIndex = 7;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(42, 261);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 8;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(147, 261);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Enabled = false;
            this.BtnVerificar.Location = new System.Drawing.Point(247, 261);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 10;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 315);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtLadoC);
            this.Controls.Add(this.TxtLadoB);
            this.Controls.Add(this.TxtLadoA);
            this.Controls.Add(this.LblLadoC);
            this.Controls.Add(this.LblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Name = "Form1";
            this.Text = "É um triângulo?";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label LblLadoB;
        private System.Windows.Forms.Label LblLadoC;
        private System.Windows.Forms.TextBox TxtLadoA;
        private System.Windows.Forms.TextBox TxtLadoB;
        private System.Windows.Forms.TextBox TxtLadoC;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

