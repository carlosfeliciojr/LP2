
namespace PVolume
{
    partial class Aplication
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
            this.LblRaio = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblVolume = new System.Windows.Forms.Label();
            this.TxtRaio = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtVolume = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRaio
            // 
            this.LblRaio.AutoSize = true;
            this.LblRaio.Location = new System.Drawing.Point(81, 28);
            this.LblRaio.Name = "LblRaio";
            this.LblRaio.Size = new System.Drawing.Size(30, 15);
            this.LblRaio.TabIndex = 7;
            this.LblRaio.Text = "Raio";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(72, 70);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(39, 15);
            this.LblAltura.TabIndex = 6;
            this.LblAltura.Text = "Altura";
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.Location = new System.Drawing.Point(64, 118);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(47, 15);
            this.LblVolume.TabIndex = 5;
            this.LblVolume.Text = "Volume";
            // 
            // TxtRaio
            // 
            this.TxtRaio.Location = new System.Drawing.Point(117, 25);
            this.TxtRaio.Name = "TxtRaio";
            this.TxtRaio.PlaceholderText = "0";
            this.TxtRaio.Size = new System.Drawing.Size(100, 23);
            this.TxtRaio.TabIndex = 0;
            this.TxtRaio.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRaio_Validating);
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(117, 67);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.PlaceholderText = "0";
            this.TxtAltura.Size = new System.Drawing.Size(100, 23);
            this.TxtAltura.TabIndex = 1;
            this.TxtAltura.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAltura_Validating);
            // 
            // TxtVolume
            // 
            this.TxtVolume.Location = new System.Drawing.Point(117, 115);
            this.TxtVolume.Name = "TxtVolume";
            this.TxtVolume.PlaceholderText = "0";
            this.TxtVolume.ReadOnly = true;
            this.TxtVolume.Size = new System.Drawing.Size(100, 23);
            this.TxtVolume.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(36, 186);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(198, 186);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(117, 186);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Aplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 230);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtVolume);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtRaio);
            this.Controls.Add(this.LblVolume);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblRaio);
            this.Name = "Aplication";
            this.Text = "Cálculo de volume";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRaio;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.TextBox TxtRaio;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtVolume;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

