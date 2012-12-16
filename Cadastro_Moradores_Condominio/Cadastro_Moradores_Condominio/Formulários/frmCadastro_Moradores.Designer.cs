namespace Cadastro_Moradores_Condominio
{
    partial class frmCadastro_Moradores
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
            this.lbMorador = new System.Windows.Forms.Label();
            this.lbPredio = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbPredio = new System.Windows.Forms.ComboBox();
            this.lbApartamento = new System.Windows.Forms.Label();
            this.lbBloco = new System.Windows.Forms.Label();
            this.cbBloco = new System.Windows.Forms.ComboBox();
            this.lbTelefones = new System.Windows.Forms.Label();
            this.lbResidencial = new System.Windows.Forms.Label();
            this.lbComercial = new System.Windows.Forms.Label();
            this.lbCelular1 = new System.Windows.Forms.Label();
            this.lbCelular2 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbIdentidade = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtIdentidade = new System.Windows.Forms.TextBox();
            this.mbCpf = new System.Windows.Forms.MaskedTextBox();
            this.ttpDDD = new System.Windows.Forms.ToolTip(this.components);
            this.mbTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.mbTelefoneComercial = new System.Windows.Forms.MaskedTextBox();
            this.mbCelular1 = new System.Windows.Forms.MaskedTextBox();
            this.mbCelular2 = new System.Windows.Forms.MaskedTextBox();
            this.btCadastroObservacoes = new System.Windows.Forms.Button();
            this.btCadastroDependentes = new System.Windows.Forms.Button();
            this.btCadastroVisitantes = new System.Windows.Forms.Button();
            this.btCadastroVeiculos = new System.Windows.Forms.Button();
            this.btCadastroLocacao = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDRespn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMorador
            // 
            this.lbMorador.AutoSize = true;
            this.lbMorador.Location = new System.Drawing.Point(12, 44);
            this.lbMorador.Name = "lbMorador";
            this.lbMorador.Size = new System.Drawing.Size(46, 13);
            this.lbMorador.TabIndex = 0;
            this.lbMorador.Text = "Morador";
            // 
            // lbPredio
            // 
            this.lbPredio.AutoSize = true;
            this.lbPredio.Location = new System.Drawing.Point(12, 70);
            this.lbPredio.Name = "lbPredio";
            this.lbPredio.Size = new System.Drawing.Size(37, 13);
            this.lbPredio.TabIndex = 1;
            this.lbPredio.Text = "Prédio";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(425, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbPredio
            // 
            this.cbPredio.FormattingEnabled = true;
            this.cbPredio.Items.AddRange(new object[] {
            "EDIF. DAS ACÁCIAS ",
            "EDIF. DAS HORTÊNCIAS ",
            "EDIF. IPÊ AMARELO ",
            "EDIF. BOUGANVILLE",
            "EDIF. DOS GIRASSÓIS ",
            "EDIF. JEQUITIBÁ ",
            "EDIF. DAS MANGUEIRAS ",
            "EDIF. FLAMBOYANT",
            "EDIF. DAS CASTANHEIRAS ",
            "EDIF. SPATIFILUS ",
            "EDIF. DAS ORQUÍDEAS ",
            "EDIF. DAS QUARESMEIRAS ",
            "EDIF. DAS CAMÉLIAS",
            "EDIF. FLOR DE LIZ",
            "EDIF. DAS LARANJEIRAS ",
            "EDIF. IPÊ BRANCO",
            "EDIF. CEDRO ",
            "EDIF. ANGICO ",
            "EDIF. AZALÉIA",
            "EDIF. SAPUCAIA"});
            this.cbPredio.Location = new System.Drawing.Point(64, 67);
            this.cbPredio.Name = "cbPredio";
            this.cbPredio.Size = new System.Drawing.Size(151, 21);
            this.cbPredio.TabIndex = 2;
            // 
            // lbApartamento
            // 
            this.lbApartamento.AutoSize = true;
            this.lbApartamento.Location = new System.Drawing.Point(252, 70);
            this.lbApartamento.Name = "lbApartamento";
            this.lbApartamento.Size = new System.Drawing.Size(27, 13);
            this.lbApartamento.TabIndex = 4;
            this.lbApartamento.Text = "Aptº";
            // 
            // lbBloco
            // 
            this.lbBloco.AutoSize = true;
            this.lbBloco.Location = new System.Drawing.Point(377, 70);
            this.lbBloco.Name = "lbBloco";
            this.lbBloco.Size = new System.Drawing.Size(34, 13);
            this.lbBloco.TabIndex = 6;
            this.lbBloco.Text = "Bloco";
            // 
            // cbBloco
            // 
            this.cbBloco.FormattingEnabled = true;
            this.cbBloco.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U"});
            this.cbBloco.Location = new System.Drawing.Point(417, 67);
            this.cbBloco.Name = "cbBloco";
            this.cbBloco.Size = new System.Drawing.Size(72, 21);
            this.cbBloco.TabIndex = 4;
            // 
            // lbTelefones
            // 
            this.lbTelefones.AutoSize = true;
            this.lbTelefones.Location = new System.Drawing.Point(12, 144);
            this.lbTelefones.Name = "lbTelefones";
            this.lbTelefones.Size = new System.Drawing.Size(54, 13);
            this.lbTelefones.TabIndex = 8;
            this.lbTelefones.Text = "Telefones";
            // 
            // lbResidencial
            // 
            this.lbResidencial.AutoSize = true;
            this.lbResidencial.Location = new System.Drawing.Point(84, 129);
            this.lbResidencial.Name = "lbResidencial";
            this.lbResidencial.Size = new System.Drawing.Size(62, 13);
            this.lbResidencial.TabIndex = 9;
            this.lbResidencial.Text = "Residencial";
            // 
            // lbComercial
            // 
            this.lbComercial.AutoSize = true;
            this.lbComercial.Location = new System.Drawing.Point(84, 161);
            this.lbComercial.Name = "lbComercial";
            this.lbComercial.Size = new System.Drawing.Size(53, 13);
            this.lbComercial.TabIndex = 10;
            this.lbComercial.Text = "Comercial";
            // 
            // lbCelular1
            // 
            this.lbCelular1.AutoSize = true;
            this.lbCelular1.Location = new System.Drawing.Point(326, 127);
            this.lbCelular1.Name = "lbCelular1";
            this.lbCelular1.Size = new System.Drawing.Size(39, 13);
            this.lbCelular1.TabIndex = 11;
            this.lbCelular1.Text = "Celular";
            // 
            // lbCelular2
            // 
            this.lbCelular2.AutoSize = true;
            this.lbCelular2.Location = new System.Drawing.Point(326, 159);
            this.lbCelular2.Name = "lbCelular2";
            this.lbCelular2.Size = new System.Drawing.Size(39, 13);
            this.lbCelular2.TabIndex = 12;
            this.lbCelular2.Text = "Celular";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 210);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "Email";
            // 
            // lbIdentidade
            // 
            this.lbIdentidade.AutoSize = true;
            this.lbIdentidade.Location = new System.Drawing.Point(12, 256);
            this.lbIdentidade.Name = "lbIdentidade";
            this.lbIdentidade.Size = new System.Drawing.Size(83, 13);
            this.lbIdentidade.TabIndex = 23;
            this.lbIdentidade.Text = "Doc. Identidade";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(252, 256);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 24;
            this.lbCpf.Text = "CPF";
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(101, 253);
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(100, 20);
            this.txtIdentidade.TabIndex = 14;
            // 
            // mbCpf
            // 
            this.mbCpf.Location = new System.Drawing.Point(285, 253);
            this.mbCpf.Mask = "000.000.000-00";
            this.mbCpf.Name = "mbCpf";
            this.mbCpf.Size = new System.Drawing.Size(86, 20);
            this.mbCpf.TabIndex = 15;
            this.mbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mbTelefoneResidencial
            // 
            this.mbTelefoneResidencial.Location = new System.Drawing.Point(152, 125);
            this.mbTelefoneResidencial.Mask = "000000000";
            this.mbTelefoneResidencial.Name = "mbTelefoneResidencial";
            this.mbTelefoneResidencial.Size = new System.Drawing.Size(108, 20);
            this.mbTelefoneResidencial.TabIndex = 6;
            // 
            // mbTelefoneComercial
            // 
            this.mbTelefoneComercial.Location = new System.Drawing.Point(152, 159);
            this.mbTelefoneComercial.Mask = "000000000";
            this.mbTelefoneComercial.Name = "mbTelefoneComercial";
            this.mbTelefoneComercial.Size = new System.Drawing.Size(108, 20);
            this.mbTelefoneComercial.TabIndex = 8;
            // 
            // mbCelular1
            // 
            this.mbCelular1.Location = new System.Drawing.Point(371, 122);
            this.mbCelular1.Mask = "000000000";
            this.mbCelular1.Name = "mbCelular1";
            this.mbCelular1.Size = new System.Drawing.Size(118, 20);
            this.mbCelular1.TabIndex = 10;
            // 
            // mbCelular2
            // 
            this.mbCelular2.Location = new System.Drawing.Point(371, 161);
            this.mbCelular2.Mask = "000000000";
            this.mbCelular2.Name = "mbCelular2";
            this.mbCelular2.Size = new System.Drawing.Size(118, 20);
            this.mbCelular2.TabIndex = 12;
            // 
            // btCadastroObservacoes
            // 
            this.btCadastroObservacoes.Location = new System.Drawing.Point(473, 296);
            this.btCadastroObservacoes.Name = "btCadastroObservacoes";
            this.btCadastroObservacoes.Size = new System.Drawing.Size(84, 44);
            this.btCadastroObservacoes.TabIndex = 20;
            this.btCadastroObservacoes.Text = "Observações";
            this.btCadastroObservacoes.UseVisualStyleBackColor = true;
            // 
            // btCadastroDependentes
            // 
            this.btCadastroDependentes.Location = new System.Drawing.Point(1, 296);
            this.btCadastroDependentes.Name = "btCadastroDependentes";
            this.btCadastroDependentes.Size = new System.Drawing.Size(80, 44);
            this.btCadastroDependentes.TabIndex = 16;
            this.btCadastroDependentes.Text = "Dependentes";
            this.btCadastroDependentes.UseVisualStyleBackColor = true;
            this.btCadastroDependentes.Click += new System.EventHandler(this.btCadastroDependentes_Click);
            // 
            // btCadastroVisitantes
            // 
            this.btCadastroVisitantes.Location = new System.Drawing.Point(111, 296);
            this.btCadastroVisitantes.Name = "btCadastroVisitantes";
            this.btCadastroVisitantes.Size = new System.Drawing.Size(80, 44);
            this.btCadastroVisitantes.TabIndex = 17;
            this.btCadastroVisitantes.Text = "Visitantes";
            this.btCadastroVisitantes.UseVisualStyleBackColor = true;
            this.btCadastroVisitantes.Click += new System.EventHandler(this.btCadastroVisitantes_Click);
            // 
            // btCadastroVeiculos
            // 
            this.btCadastroVeiculos.Location = new System.Drawing.Point(224, 296);
            this.btCadastroVeiculos.Name = "btCadastroVeiculos";
            this.btCadastroVeiculos.Size = new System.Drawing.Size(84, 44);
            this.btCadastroVeiculos.TabIndex = 18;
            this.btCadastroVeiculos.Text = "Veículo";
            this.btCadastroVeiculos.UseVisualStyleBackColor = true;
            this.btCadastroVeiculos.Click += new System.EventHandler(this.btCadastroVeiculos_Click);
            // 
            // btCadastroLocacao
            // 
            this.btCadastroLocacao.Location = new System.Drawing.Point(349, 296);
            this.btCadastroLocacao.Name = "btCadastroLocacao";
            this.btCadastroLocacao.Size = new System.Drawing.Size(84, 44);
            this.btCadastroLocacao.TabIndex = 19;
            this.btCadastroLocacao.Text = "Locação";
            this.btCadastroLocacao.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(495, 41);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 54);
            this.btSalvar.TabIndex = 21;
            this.btSalvar.Text = "Salvar Dados";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(64, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // txtIDRespn
            // 
            this.txtIDRespn.Location = new System.Drawing.Point(470, 230);
            this.txtIDRespn.Name = "txtIDRespn";
            this.txtIDRespn.Size = new System.Drawing.Size(100, 20);
            this.txtIDRespn.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID do Responsavel";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Location = new System.Drawing.Point(285, 68);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(67, 20);
            this.txtApartamento.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // frmCadastro_Moradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 398);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDRespn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCadastroLocacao);
            this.Controls.Add(this.btCadastroVeiculos);
            this.Controls.Add(this.btCadastroVisitantes);
            this.Controls.Add(this.btCadastroDependentes);
            this.Controls.Add(this.btCadastroObservacoes);
            this.Controls.Add(this.mbCelular2);
            this.Controls.Add(this.mbCelular1);
            this.Controls.Add(this.mbTelefoneComercial);
            this.Controls.Add(this.mbTelefoneResidencial);
            this.Controls.Add(this.mbCpf);
            this.Controls.Add(this.txtIdentidade);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbIdentidade);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCelular2);
            this.Controls.Add(this.lbCelular1);
            this.Controls.Add(this.lbComercial);
            this.Controls.Add(this.lbResidencial);
            this.Controls.Add(this.lbTelefones);
            this.Controls.Add(this.cbBloco);
            this.Controls.Add(this.lbBloco);
            this.Controls.Add(this.lbApartamento);
            this.Controls.Add(this.cbPredio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbPredio);
            this.Controls.Add(this.lbMorador);
            this.MaximizeBox = false;
            this.Name = "frmCadastro_Moradores";
            this.Text = "Cadastro de Moradores";
            this.Load += new System.EventHandler(this.frmCadastro_Moradores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMorador;
        private System.Windows.Forms.Label lbPredio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbPredio;
        private System.Windows.Forms.Label lbApartamento;
        private System.Windows.Forms.Label lbBloco;
        private System.Windows.Forms.ComboBox cbBloco;
        private System.Windows.Forms.Label lbTelefones;
        private System.Windows.Forms.Label lbResidencial;
        private System.Windows.Forms.Label lbComercial;
        private System.Windows.Forms.Label lbCelular1;
        private System.Windows.Forms.Label lbCelular2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbIdentidade;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtIdentidade;
        private System.Windows.Forms.MaskedTextBox mbCpf;
        private System.Windows.Forms.ToolTip ttpDDD;
        private System.Windows.Forms.MaskedTextBox mbTelefoneResidencial;
        private System.Windows.Forms.MaskedTextBox mbTelefoneComercial;
        private System.Windows.Forms.MaskedTextBox mbCelular1;
        private System.Windows.Forms.MaskedTextBox mbCelular2;
        private System.Windows.Forms.Button btCadastroObservacoes;
        private System.Windows.Forms.Button btCadastroDependentes;
        private System.Windows.Forms.Button btCadastroVisitantes;
        private System.Windows.Forms.Button btCadastroVeiculos;
        private System.Windows.Forms.Button btCadastroLocacao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDRespn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

