namespace Cadastro_Moradores_Condominio.Formulários
{
    partial class frmCadastro_Dependente
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbParentesco = new System.Windows.Forms.Label();
            this.lbFone = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cbParentesco = new System.Windows.Forms.ComboBox();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.lbIdRespons = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(11, 77);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID";
            // 
            // lbParentesco
            // 
            this.lbParentesco.AutoSize = true;
            this.lbParentesco.Location = new System.Drawing.Point(12, 123);
            this.lbParentesco.Name = "lbParentesco";
            this.lbParentesco.Size = new System.Drawing.Size(104, 13);
            this.lbParentesco.TabIndex = 3;
            this.lbParentesco.Text = "Parentesco/Ligação";
            // 
            // lbFone
            // 
            this.lbFone.AutoSize = true;
            this.lbFone.Location = new System.Drawing.Point(264, 126);
            this.lbFone.Name = "lbFone";
            this.lbFone.Size = new System.Drawing.Size(49, 13);
            this.lbFone.TabIndex = 4;
            this.lbFone.Text = "Telefone";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(35, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(319, 121);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // cbParentesco
            // 
            this.cbParentesco.FormattingEnabled = true;
            this.cbParentesco.Location = new System.Drawing.Point(122, 120);
            this.cbParentesco.Name = "cbParentesco";
            this.cbParentesco.Size = new System.Drawing.Size(121, 21);
            this.cbParentesco.TabIndex = 8;
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Location = new System.Drawing.Point(183, 9);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(49, 13);
            this.lbCadastro.TabIndex = 9;
            this.lbCadastro.Text = "Cadastro";
            // 
            // lbIdRespons
            // 
            this.lbIdRespons.AutoSize = true;
            this.lbIdRespons.Location = new System.Drawing.Point(347, 39);
            this.lbIdRespons.Name = "lbIdRespons";
            this.lbIdRespons.Size = new System.Drawing.Size(72, 13);
            this.lbIdRespons.TabIndex = 11;
            this.lbIdRespons.Text = "IDdoRespons";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(267, 162);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(353, 162);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmCadastro_Dependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 204);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbIdRespons);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.cbParentesco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbFone);
            this.Controls.Add(this.lbParentesco);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbNome);
            this.Name = "frmCadastro_Dependente";
            this.Text = "Cadastro de Dependentes";
            this.Load += new System.EventHandler(this.frmCadastro_Dependentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbParentesco;
        private System.Windows.Forms.Label lbFone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cbParentesco;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Label lbIdRespons;
        // private System.Windows.Forms.ColumnHeader IdResponsavel;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}