namespace Cadastro_Moradores_Condominio
{
    partial class frmCadastroLocacao
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
            this.components = new System.ComponentModel.Container();
            this.mbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbProprietario = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDddTelefone = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbImobiliaria = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.ttpDDD = new System.Windows.Forms.ToolTip(this.components);
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mbTelefone
            // 
            this.mbTelefone.Location = new System.Drawing.Point(426, 60);
            this.mbTelefone.Mask = "000000000";
            this.mbTelefone.Name = "mbTelefone";
            this.mbTelefone.Size = new System.Drawing.Size(63, 20);
            this.mbTelefone.TabIndex = 5;
            // 
            // tbProprietario
            // 
            this.tbProprietario.Location = new System.Drawing.Point(136, 99);
            this.tbProprietario.Name = "tbProprietario";
            this.tbProprietario.Size = new System.Drawing.Size(353, 20);
            this.tbProprietario.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Proprietário do Imóvel";
            // 
            // cbDddTelefone
            // 
            this.cbDddTelefone.FormattingEnabled = true;
            this.cbDddTelefone.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "21",
            "22",
            "24",
            "27",
            "28",
            "31",
            "32",
            "33",
            "34",
            "35",
            "37",
            "38",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "51",
            "53",
            "54",
            "55",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "71",
            "73",
            "74",
            "75",
            "77",
            "79",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cbDddTelefone.Location = new System.Drawing.Point(372, 60);
            this.cbDddTelefone.Name = "cbDddTelefone";
            this.cbDddTelefone.Size = new System.Drawing.Size(39, 21);
            this.cbDddTelefone.TabIndex = 4;
            this.cbDddTelefone.Text = "31";
            this.cbDddTelefone.MouseLeave += new System.EventHandler(this.comboBox7_MouseLeave);
            this.cbDddTelefone.MouseHover += new System.EventHandler(this.comboBox7_MouseHover);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Telefone";
            // 
            // tbImobiliaria
            // 
            this.tbImobiliaria.Location = new System.Drawing.Point(71, 60);
            this.tbImobiliaria.Name = "tbImobiliaria";
            this.tbImobiliaria.Size = new System.Drawing.Size(226, 20);
            this.tbImobiliaria.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Imobiliária";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(188, 18);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 2;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(127, 18);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 1;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Unidade Alugada?";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(15, 118);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 49);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // CadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 170);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.mbTelefone);
            this.Controls.Add(this.tbProprietario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbDddTelefone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbImobiliaria);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.label13);
            this.MaximizeBox = false;
            this.Name = "CadastroLocacao";
            this.Text = "Aluguel";
            this.Load += new System.EventHandler(this.CadastroLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mbTelefone;
        private System.Windows.Forms.TextBox tbProprietario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbDddTelefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbImobiliaria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip ttpDDD;
        private System.Windows.Forms.Button btSalvar;

    }
}