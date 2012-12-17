namespace Cadastro_Moradores_Condominio
{
    partial class frmCadastro_Locacao
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
            this.txtFoneImobiliaria = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeProprietario = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtImobiliaria = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.ttpDDD = new System.Windows.Forms.ToolTip(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbFoneProprietario = new System.Windows.Forms.Label();
            this.txtFoneProprietario = new System.Windows.Forms.MaskedTextBox();
            this.gbLocacao = new System.Windows.Forms.GroupBox();
            this.lbIdRespons = new System.Windows.Forms.Label();
            this.gbLocacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFoneImobiliaria
            // 
            this.txtFoneImobiliaria.Location = new System.Drawing.Point(141, 174);
            this.txtFoneImobiliaria.Mask = "(00) 0000-0000";
            this.txtFoneImobiliaria.Name = "txtFoneImobiliaria";
            this.txtFoneImobiliaria.Size = new System.Drawing.Size(105, 20);
            this.txtFoneImobiliaria.TabIndex = 5;
            // 
            // txtNomeProprietario
            // 
            this.txtNomeProprietario.Location = new System.Drawing.Point(127, 68);
            this.txtNomeProprietario.Name = "txtNomeProprietario";
            this.txtNomeProprietario.Size = new System.Drawing.Size(353, 20);
            this.txtNomeProprietario.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Proprietário do Imóvel";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Telefone da Imomiliaria";
            // 
            // txtImobiliaria
            // 
            this.txtImobiliaria.Location = new System.Drawing.Point(75, 136);
            this.txtImobiliaria.Name = "txtImobiliaria";
            this.txtImobiliaria.Size = new System.Drawing.Size(405, 20);
            this.txtImobiliaria.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Imobiliária";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(91, 16);
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
            this.rbSim.Location = new System.Drawing.Point(21, 16);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 1;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(405, 199);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 52;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click_1);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(309, 201);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 21);
            this.btSalvar.TabIndex = 51;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbFoneProprietario
            // 
            this.lbFoneProprietario.AutoSize = true;
            this.lbFoneProprietario.Location = new System.Drawing.Point(12, 100);
            this.lbFoneProprietario.Name = "lbFoneProprietario";
            this.lbFoneProprietario.Size = new System.Drawing.Size(120, 13);
            this.lbFoneProprietario.TabIndex = 53;
            this.lbFoneProprietario.Text = "Telefone do Proprietário";
            // 
            // txtFoneProprietario
            // 
            this.txtFoneProprietario.Location = new System.Drawing.Point(140, 97);
            this.txtFoneProprietario.Mask = "(00) 0000-0000";
            this.txtFoneProprietario.Name = "txtFoneProprietario";
            this.txtFoneProprietario.Size = new System.Drawing.Size(83, 20);
            this.txtFoneProprietario.TabIndex = 54;
            // 
            // gbLocacao
            // 
            this.gbLocacao.Controls.Add(this.rbNao);
            this.gbLocacao.Controls.Add(this.rbSim);
            this.gbLocacao.Location = new System.Drawing.Point(17, 12);
            this.gbLocacao.Name = "gbLocacao";
            this.gbLocacao.Size = new System.Drawing.Size(162, 39);
            this.gbLocacao.TabIndex = 55;
            this.gbLocacao.TabStop = false;
            this.gbLocacao.Text = "Unidade Alugada?";
            // 
            // lbIdRespons
            // 
            this.lbIdRespons.AutoSize = true;
            this.lbIdRespons.Location = new System.Drawing.Point(394, 38);
            this.lbIdRespons.Name = "lbIdRespons";
            this.lbIdRespons.Size = new System.Drawing.Size(86, 13);
            this.lbIdRespons.TabIndex = 56;
            this.lbIdRespons.Text = "lbIdResponsavel";
            // 
            // frmCadastro_Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 234);
            this.Controls.Add(this.lbIdRespons);
            this.Controls.Add(this.gbLocacao);
            this.Controls.Add(this.txtFoneProprietario);
            this.Controls.Add(this.lbFoneProprietario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtFoneImobiliaria);
            this.Controls.Add(this.txtNomeProprietario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtImobiliaria);
            this.Controls.Add(this.label14);
            this.MaximizeBox = false;
            this.Name = "frmCadastro_Locacao";
            this.Text = "Apartamento";
            this.Load += new System.EventHandler(this.frmCadastro_Locacao_Load);
            this.gbLocacao.ResumeLayout(false);
            this.gbLocacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFoneImobiliaria;
        private System.Windows.Forms.TextBox txtNomeProprietario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtImobiliaria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.ToolTip ttpDDD;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbFoneProprietario;
        private System.Windows.Forms.MaskedTextBox txtFoneProprietario;
        private System.Windows.Forms.GroupBox gbLocacao;
        private System.Windows.Forms.Label lbIdRespons;

    }
}