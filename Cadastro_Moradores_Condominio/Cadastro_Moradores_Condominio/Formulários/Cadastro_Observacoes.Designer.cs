namespace Cadastro_Moradores_Condominio
{
    partial class CadastroObservacoes
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
            this.rtbObservacoes = new System.Windows.Forms.RichTextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbObservacoes
            // 
            this.rtbObservacoes.Location = new System.Drawing.Point(12, 6);
            this.rtbObservacoes.Name = "rtbObservacoes";
            this.rtbObservacoes.Size = new System.Drawing.Size(462, 119);
            this.rtbObservacoes.TabIndex = 1;
            this.rtbObservacoes.Text = "";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 131);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 45);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // CadastroObservacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 179);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.rtbObservacoes);
            this.MaximizeBox = false;
            this.Name = "CadastroObservacoes";
            this.Text = "Observações";
            this.Load += new System.EventHandler(this.CadastroObservacoes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbObservacoes;
        private System.Windows.Forms.Button btSalvar;
    }
}