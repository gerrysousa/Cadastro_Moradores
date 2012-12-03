namespace Cadastro_Moradores_Condominio
{
    partial class Cadastro_Moradores
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
            this.tbMorador = new System.Windows.Forms.TextBox();
            this.cbPredio = new System.Windows.Forms.ComboBox();
            this.lbApartamento = new System.Windows.Forms.Label();
            this.lbBloco = new System.Windows.Forms.Label();
            this.cbBloco = new System.Windows.Forms.ComboBox();
            this.lbTelefones = new System.Windows.Forms.Label();
            this.lbResidencial = new System.Windows.Forms.Label();
            this.lbComercial = new System.Windows.Forms.Label();
            this.lbCelular1 = new System.Windows.Forms.Label();
            this.lbCelular2 = new System.Windows.Forms.Label();
            this.cbDddResidencial = new System.Windows.Forms.ComboBox();
            this.cbDddComercial = new System.Windows.Forms.ComboBox();
            this.cbDddCelular2 = new System.Windows.Forms.ComboBox();
            this.cbDddCelular1 = new System.Windows.Forms.ComboBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbIdentidade = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.tbIdentidade = new System.Windows.Forms.TextBox();
            this.mbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mbApartamento = new System.Windows.Forms.MaskedTextBox();
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
            this.SuspendLayout();
            // 
            // lbMorador
            // 
            this.lbMorador.AutoSize = true;
            this.lbMorador.Location = new System.Drawing.Point(23, 9);
            this.lbMorador.Name = "lbMorador";
            this.lbMorador.Size = new System.Drawing.Size(46, 13);
            this.lbMorador.TabIndex = 0;
            this.lbMorador.Text = "Morador";
            // 
            // lbPredio
            // 
            this.lbPredio.AutoSize = true;
            this.lbPredio.Location = new System.Drawing.Point(23, 35);
            this.lbPredio.Name = "lbPredio";
            this.lbPredio.Size = new System.Drawing.Size(37, 13);
            this.lbPredio.TabIndex = 1;
            this.lbPredio.Text = "Prédio";
            // 
            // tbMorador
            // 
            this.tbMorador.Location = new System.Drawing.Point(75, 6);
            this.tbMorador.Name = "tbMorador";
            this.tbMorador.Size = new System.Drawing.Size(425, 20);
            this.tbMorador.TabIndex = 1;
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
            this.cbPredio.Location = new System.Drawing.Point(75, 32);
            this.cbPredio.Name = "cbPredio";
            this.cbPredio.Size = new System.Drawing.Size(151, 21);
            this.cbPredio.TabIndex = 2;
            // 
            // lbApartamento
            // 
            this.lbApartamento.AutoSize = true;
            this.lbApartamento.Location = new System.Drawing.Point(263, 35);
            this.lbApartamento.Name = "lbApartamento";
            this.lbApartamento.Size = new System.Drawing.Size(27, 13);
            this.lbApartamento.TabIndex = 4;
            this.lbApartamento.Text = "Aptº";
            // 
            // lbBloco
            // 
            this.lbBloco.AutoSize = true;
            this.lbBloco.Location = new System.Drawing.Point(388, 35);
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
            this.cbBloco.Location = new System.Drawing.Point(428, 32);
            this.cbBloco.Name = "cbBloco";
            this.cbBloco.Size = new System.Drawing.Size(72, 21);
            this.cbBloco.TabIndex = 4;
            // 
            // lbTelefones
            // 
            this.lbTelefones.AutoSize = true;
            this.lbTelefones.Location = new System.Drawing.Point(23, 109);
            this.lbTelefones.Name = "lbTelefones";
            this.lbTelefones.Size = new System.Drawing.Size(54, 13);
            this.lbTelefones.TabIndex = 8;
            this.lbTelefones.Text = "Telefones";
            // 
            // lbResidencial
            // 
            this.lbResidencial.AutoSize = true;
            this.lbResidencial.Location = new System.Drawing.Point(95, 94);
            this.lbResidencial.Name = "lbResidencial";
            this.lbResidencial.Size = new System.Drawing.Size(62, 13);
            this.lbResidencial.TabIndex = 9;
            this.lbResidencial.Text = "Residencial";
            // 
            // lbComercial
            // 
            this.lbComercial.AutoSize = true;
            this.lbComercial.Location = new System.Drawing.Point(95, 126);
            this.lbComercial.Name = "lbComercial";
            this.lbComercial.Size = new System.Drawing.Size(53, 13);
            this.lbComercial.TabIndex = 10;
            this.lbComercial.Text = "Comercial";
            // 
            // lbCelular1
            // 
            this.lbCelular1.AutoSize = true;
            this.lbCelular1.Location = new System.Drawing.Point(337, 92);
            this.lbCelular1.Name = "lbCelular1";
            this.lbCelular1.Size = new System.Drawing.Size(39, 13);
            this.lbCelular1.TabIndex = 11;
            this.lbCelular1.Text = "Celular";
            // 
            // lbCelular2
            // 
            this.lbCelular2.AutoSize = true;
            this.lbCelular2.Location = new System.Drawing.Point(337, 124);
            this.lbCelular2.Name = "lbCelular2";
            this.lbCelular2.Size = new System.Drawing.Size(39, 13);
            this.lbCelular2.TabIndex = 12;
            this.lbCelular2.Text = "Celular";
            // 
            // cbDddResidencial
            // 
            this.cbDddResidencial.FormattingEnabled = true;
            this.cbDddResidencial.Items.AddRange(new object[] {
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
            this.cbDddResidencial.Location = new System.Drawing.Point(163, 89);
            this.cbDddResidencial.Name = "cbDddResidencial";
            this.cbDddResidencial.Size = new System.Drawing.Size(39, 21);
            this.cbDddResidencial.TabIndex = 5;
            this.cbDddResidencial.Text = "31";
            this.cbDddResidencial.MouseLeave += new System.EventHandler(this.comboBox3_MouseLeave);
            this.cbDddResidencial.MouseHover += new System.EventHandler(this.comboBox3_MouseHover);
            // 
            // cbDddComercial
            // 
            this.cbDddComercial.FormattingEnabled = true;
            this.cbDddComercial.Items.AddRange(new object[] {
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
            this.cbDddComercial.Location = new System.Drawing.Point(163, 123);
            this.cbDddComercial.Name = "cbDddComercial";
            this.cbDddComercial.Size = new System.Drawing.Size(39, 21);
            this.cbDddComercial.TabIndex = 7;
            this.cbDddComercial.Text = "31";
            this.cbDddComercial.MouseLeave += new System.EventHandler(this.comboBox4_MouseLeave);
            this.cbDddComercial.MouseHover += new System.EventHandler(this.comboBox4_MouseHover);
            // 
            // cbDddCelular2
            // 
            this.cbDddCelular2.FormattingEnabled = true;
            this.cbDddCelular2.Items.AddRange(new object[] {
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
            this.cbDddCelular2.Location = new System.Drawing.Point(382, 124);
            this.cbDddCelular2.Name = "cbDddCelular2";
            this.cbDddCelular2.Size = new System.Drawing.Size(39, 21);
            this.cbDddCelular2.TabIndex = 11;
            this.cbDddCelular2.Text = "31";
            this.cbDddCelular2.MouseLeave += new System.EventHandler(this.comboBox5_MouseLeave);
            this.cbDddCelular2.MouseHover += new System.EventHandler(this.comboBox5_MouseHover);
            // 
            // cbDddCelular1
            // 
            this.cbDddCelular1.FormattingEnabled = true;
            this.cbDddCelular1.Items.AddRange(new object[] {
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
            this.cbDddCelular1.Location = new System.Drawing.Point(382, 90);
            this.cbDddCelular1.Name = "cbDddCelular1";
            this.cbDddCelular1.Size = new System.Drawing.Size(39, 21);
            this.cbDddCelular1.TabIndex = 9;
            this.cbDddCelular1.Text = "31";
            this.cbDddCelular1.MouseLeave += new System.EventHandler(this.comboBox6_MouseLeave);
            this.cbDddCelular1.MouseHover += new System.EventHandler(this.comboBox6_MouseHover);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 175);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(75, 172);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(307, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // lbIdentidade
            // 
            this.lbIdentidade.AutoSize = true;
            this.lbIdentidade.Location = new System.Drawing.Point(23, 221);
            this.lbIdentidade.Name = "lbIdentidade";
            this.lbIdentidade.Size = new System.Drawing.Size(83, 13);
            this.lbIdentidade.TabIndex = 23;
            this.lbIdentidade.Text = "Doc. Identidade";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(263, 221);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 24;
            this.lbCpf.Text = "CPF";
            // 
            // tbIdentidade
            // 
            this.tbIdentidade.Location = new System.Drawing.Point(112, 218);
            this.tbIdentidade.Name = "tbIdentidade";
            this.tbIdentidade.Size = new System.Drawing.Size(100, 20);
            this.tbIdentidade.TabIndex = 14;
            // 
            // mbCpf
            // 
            this.mbCpf.Location = new System.Drawing.Point(296, 218);
            this.mbCpf.Mask = "000.000.000-00";
            this.mbCpf.Name = "mbCpf";
            this.mbCpf.Size = new System.Drawing.Size(86, 20);
            this.mbCpf.TabIndex = 15;
            this.mbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mbApartamento
            // 
            this.mbApartamento.Location = new System.Drawing.Point(296, 32);
            this.mbApartamento.Mask = "00000";
            this.mbApartamento.Name = "mbApartamento";
            this.mbApartamento.PromptChar = ' ';
            this.mbApartamento.Size = new System.Drawing.Size(42, 20);
            this.mbApartamento.TabIndex = 3;
            this.mbApartamento.ValidatingType = typeof(int);
            // 
            // mbTelefoneResidencial
            // 
            this.mbTelefoneResidencial.Location = new System.Drawing.Point(208, 90);
            this.mbTelefoneResidencial.Mask = "000000000";
            this.mbTelefoneResidencial.Name = "mbTelefoneResidencial";
            this.mbTelefoneResidencial.Size = new System.Drawing.Size(63, 20);
            this.mbTelefoneResidencial.TabIndex = 6;
            // 
            // mbTelefoneComercial
            // 
            this.mbTelefoneComercial.Location = new System.Drawing.Point(208, 124);
            this.mbTelefoneComercial.Mask = "000000000";
            this.mbTelefoneComercial.Name = "mbTelefoneComercial";
            this.mbTelefoneComercial.Size = new System.Drawing.Size(63, 20);
            this.mbTelefoneComercial.TabIndex = 8;
            // 
            // mbCelular1
            // 
            this.mbCelular1.Location = new System.Drawing.Point(437, 87);
            this.mbCelular1.Mask = "000000000";
            this.mbCelular1.Name = "mbCelular1";
            this.mbCelular1.Size = new System.Drawing.Size(63, 20);
            this.mbCelular1.TabIndex = 10;
            // 
            // mbCelular2
            // 
            this.mbCelular2.Location = new System.Drawing.Point(437, 126);
            this.mbCelular2.Mask = "000000000";
            this.mbCelular2.Name = "mbCelular2";
            this.mbCelular2.Size = new System.Drawing.Size(63, 20);
            this.mbCelular2.TabIndex = 12;
            // 
            // btCadastroObservacoes
            // 
            this.btCadastroObservacoes.Location = new System.Drawing.Point(484, 261);
            this.btCadastroObservacoes.Name = "btCadastroObservacoes";
            this.btCadastroObservacoes.Size = new System.Drawing.Size(84, 44);
            this.btCadastroObservacoes.TabIndex = 20;
            this.btCadastroObservacoes.Text = "Observações";
            this.btCadastroObservacoes.UseVisualStyleBackColor = true;
            this.btCadastroObservacoes.Click += new System.EventHandler(this.btCadastroObservacoes_Click);
            // 
            // btCadastroDependentes
            // 
            this.btCadastroDependentes.Location = new System.Drawing.Point(12, 261);
            this.btCadastroDependentes.Name = "btCadastroDependentes";
            this.btCadastroDependentes.Size = new System.Drawing.Size(80, 44);
            this.btCadastroDependentes.TabIndex = 16;
            this.btCadastroDependentes.Text = "Dependentes";
            this.btCadastroDependentes.UseVisualStyleBackColor = true;
            this.btCadastroDependentes.Click += new System.EventHandler(this.btCadastroDependentes_Click);
            // 
            // btCadastroVisitantes
            // 
            this.btCadastroVisitantes.Location = new System.Drawing.Point(122, 261);
            this.btCadastroVisitantes.Name = "btCadastroVisitantes";
            this.btCadastroVisitantes.Size = new System.Drawing.Size(80, 44);
            this.btCadastroVisitantes.TabIndex = 17;
            this.btCadastroVisitantes.Text = "Visitantes";
            this.btCadastroVisitantes.UseVisualStyleBackColor = true;
            this.btCadastroVisitantes.Click += new System.EventHandler(this.btCadastroVisitantes_Click);
            // 
            // btCadastroVeiculos
            // 
            this.btCadastroVeiculos.Location = new System.Drawing.Point(235, 261);
            this.btCadastroVeiculos.Name = "btCadastroVeiculos";
            this.btCadastroVeiculos.Size = new System.Drawing.Size(84, 44);
            this.btCadastroVeiculos.TabIndex = 18;
            this.btCadastroVeiculos.Text = "Veículo";
            this.btCadastroVeiculos.UseVisualStyleBackColor = true;
            this.btCadastroVeiculos.Click += new System.EventHandler(this.btCadastroVeiculos_Click);
            // 
            // btCadastroLocacao
            // 
            this.btCadastroLocacao.Location = new System.Drawing.Point(360, 261);
            this.btCadastroLocacao.Name = "btCadastroLocacao";
            this.btCadastroLocacao.Size = new System.Drawing.Size(84, 44);
            this.btCadastroLocacao.TabIndex = 19;
            this.btCadastroLocacao.Text = "Locação";
            this.btCadastroLocacao.UseVisualStyleBackColor = true;
            this.btCadastroLocacao.Click += new System.EventHandler(this.btCadastroLocacao_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(506, 6);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 54);
            this.btSalvar.TabIndex = 21;
            this.btSalvar.Text = "Salvar Dados";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Cadastro_Moradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 322);
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
            this.Controls.Add(this.mbApartamento);
            this.Controls.Add(this.mbCpf);
            this.Controls.Add(this.tbIdentidade);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbIdentidade);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.cbDddCelular2);
            this.Controls.Add(this.cbDddCelular1);
            this.Controls.Add(this.cbDddComercial);
            this.Controls.Add(this.cbDddResidencial);
            this.Controls.Add(this.lbCelular2);
            this.Controls.Add(this.lbCelular1);
            this.Controls.Add(this.lbComercial);
            this.Controls.Add(this.lbResidencial);
            this.Controls.Add(this.lbTelefones);
            this.Controls.Add(this.cbBloco);
            this.Controls.Add(this.lbBloco);
            this.Controls.Add(this.lbApartamento);
            this.Controls.Add(this.cbPredio);
            this.Controls.Add(this.tbMorador);
            this.Controls.Add(this.lbPredio);
            this.Controls.Add(this.lbMorador);
            this.MaximizeBox = false;
            this.Name = "Cadastro_Moradores";
            this.Text = "Cadastro de Moradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMorador;
        private System.Windows.Forms.Label lbPredio;
        private System.Windows.Forms.TextBox tbMorador;
        private System.Windows.Forms.ComboBox cbPredio;
        private System.Windows.Forms.Label lbApartamento;
        private System.Windows.Forms.Label lbBloco;
        private System.Windows.Forms.ComboBox cbBloco;
        private System.Windows.Forms.Label lbTelefones;
        private System.Windows.Forms.Label lbResidencial;
        private System.Windows.Forms.Label lbComercial;
        private System.Windows.Forms.Label lbCelular1;
        private System.Windows.Forms.Label lbCelular2;
        private System.Windows.Forms.ComboBox cbDddResidencial;
        private System.Windows.Forms.ComboBox cbDddComercial;
        private System.Windows.Forms.ComboBox cbDddCelular2;
        private System.Windows.Forms.ComboBox cbDddCelular1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbIdentidade;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox tbIdentidade;
        private System.Windows.Forms.MaskedTextBox mbCpf;
        private System.Windows.Forms.MaskedTextBox mbApartamento;
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
    }
}

