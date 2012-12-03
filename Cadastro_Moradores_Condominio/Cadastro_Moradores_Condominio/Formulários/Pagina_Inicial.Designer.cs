namespace Cadastro_Moradores_Condominio
{
    partial class Pagina_Inicial
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
            this.btCadastrarMoradores = new System.Windows.Forms.Button();
            this.btMoradoresCadastrados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarMoradores
            // 
            this.btCadastrarMoradores.Location = new System.Drawing.Point(12, 44);
            this.btCadastrarMoradores.Name = "btCadastrarMoradores";
            this.btCadastrarMoradores.Size = new System.Drawing.Size(101, 51);
            this.btCadastrarMoradores.TabIndex = 1;
            this.btCadastrarMoradores.Text = "Cadastrar Moradores";
            this.btCadastrarMoradores.UseVisualStyleBackColor = true;
            this.btCadastrarMoradores.Click += new System.EventHandler(this.btCadastrarMoradores_Click);
            // 
            // btMoradoresCadastrados
            // 
            this.btMoradoresCadastrados.Location = new System.Drawing.Point(218, 44);
            this.btMoradoresCadastrados.Name = "btMoradoresCadastrados";
            this.btMoradoresCadastrados.Size = new System.Drawing.Size(101, 51);
            this.btMoradoresCadastrados.TabIndex = 2;
            this.btMoradoresCadastrados.Text = "Moradores Cadastrados";
            this.btMoradoresCadastrados.UseVisualStyleBackColor = true;
            this.btMoradoresCadastrados.Click += new System.EventHandler(this.btMoradoresCadastrados_Click);
            // 
            // Pagina_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 134);
            this.Controls.Add(this.btMoradoresCadastrados);
            this.Controls.Add(this.btCadastrarMoradores);
            this.MaximizeBox = false;
            this.Name = "Pagina_Inicial";
            this.Text = "Pagina Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarMoradores;
        private System.Windows.Forms.Button btMoradoresCadastrados;
    }
}