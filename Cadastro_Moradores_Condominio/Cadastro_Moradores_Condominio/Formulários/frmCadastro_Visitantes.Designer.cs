namespace Cadastro_Moradores_Condominio
{
    partial class frmCadastro_Visitantes
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
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbIdRespons = new System.Windows.Forms.Label();
            this.cbParentesco = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbParentesco = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(244, 142);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 21);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbIdRespons
            // 
            this.lbIdRespons.AutoSize = true;
            this.lbIdRespons.Location = new System.Drawing.Point(337, 20);
            this.lbIdRespons.Name = "lbIdRespons";
            this.lbIdRespons.Size = new System.Drawing.Size(72, 13);
            this.lbIdRespons.TabIndex = 23;
            this.lbIdRespons.Text = "IDdoRespons";
            // 
            // cbParentesco
            // 
            this.cbParentesco.FormattingEnabled = true;
            this.cbParentesco.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmã(o)",
            "Parente",
            "Amigo",
            "Outro"});
            this.cbParentesco.Location = new System.Drawing.Point(112, 101);
            this.cbParentesco.Name = "cbParentesco";
            this.cbParentesco.Size = new System.Drawing.Size(121, 21);
            this.cbParentesco.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(42, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(373, 20);
            this.txtNome.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(42, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(62, 20);
            this.txtID.TabIndex = 18;
            // 
            // lbParentesco
            // 
            this.lbParentesco.AutoSize = true;
            this.lbParentesco.Location = new System.Drawing.Point(2, 104);
            this.lbParentesco.Name = "lbParentesco";
            this.lbParentesco.Size = new System.Drawing.Size(104, 13);
            this.lbParentesco.TabIndex = 16;
            this.lbParentesco.Text = "Parentesco/Ligação";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(19, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(1, 58);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(340, 140);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmCadastro_Visitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 180);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbIdRespons);
            this.Controls.Add(this.cbParentesco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbParentesco);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btSalvar);
            this.MaximizeBox = false;
            this.Name = "frmCadastro_Visitantes";
            this.Text = "Cadastro de Visitantes";
            this.Load += new System.EventHandler(this.frmCadastro_Visitantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbIdRespons;
        private System.Windows.Forms.ComboBox cbParentesco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbParentesco;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btCancelar;

    }
}