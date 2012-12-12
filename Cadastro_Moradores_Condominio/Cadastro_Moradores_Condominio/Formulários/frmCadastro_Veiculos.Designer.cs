namespace Cadastro_Moradores_Condominio
{
    partial class frmCadastroVeiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVeiculo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.mkbAno = new System.Windows.Forms.MaskedTextBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cor";
            // 
            // tbVeiculo
            // 
            this.tbVeiculo.Location = new System.Drawing.Point(62, 6);
            this.tbVeiculo.Name = "tbVeiculo";
            this.tbVeiculo.Size = new System.Drawing.Size(100, 20);
            this.tbVeiculo.TabIndex = 1;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(219, 6);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 2;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(390, 6);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 3;
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(62, 54);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(100, 20);
            this.tbPlaca.TabIndex = 4;
            // 
            // mkbAno
            // 
            this.mkbAno.Location = new System.Drawing.Point(219, 54);
            this.mkbAno.Mask = "0000";
            this.mkbAno.Name = "mkbAno";
            this.mkbAno.PromptChar = ' ';
            this.mkbAno.Size = new System.Drawing.Size(36, 20);
            this.mkbAno.TabIndex = 5;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Amarelo",
            "Azul",
            "Branco",
            "Cinza",
            "Marrom/Bege",
            "Vermelho",
            "Prata",
            "Preto",
            "Verde",
            "Outra"});
            this.cbCor.Location = new System.Drawing.Point(387, 54);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(103, 21);
            this.cbCor.TabIndex = 6;
            this.cbCor.Text = "Prata";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 90);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 47);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // CadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 141);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.mkbAno);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastroVeiculos";
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.CadastroVeiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVeiculo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.MaskedTextBox mkbAno;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Button btSalvar;
    }
}