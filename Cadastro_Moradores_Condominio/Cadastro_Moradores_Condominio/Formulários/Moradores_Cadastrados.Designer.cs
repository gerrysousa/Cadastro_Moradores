namespace Cadastro_Moradores_Condominio
{
    partial class MoradoresCadastrados
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
            this.dgvMoradoresCadastrados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLocacao = new System.Windows.Forms.Button();
            this.btVeículo = new System.Windows.Forms.Button();
            this.btObservacoes = new System.Windows.Forms.Button();
            this.btVisitantes = new System.Windows.Forms.Button();
            this.btDependentesCadastrados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradoresCadastrados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMoradoresCadastrados
            // 
            this.dgvMoradoresCadastrados.AllowUserToAddRows = false;
            this.dgvMoradoresCadastrados.AllowUserToDeleteRows = false;
            this.dgvMoradoresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoradoresCadastrados.Location = new System.Drawing.Point(0, 0);
            this.dgvMoradoresCadastrados.Name = "dgvMoradoresCadastrados";
            this.dgvMoradoresCadastrados.ReadOnly = true;
            this.dgvMoradoresCadastrados.Size = new System.Drawing.Size(847, 637);
            this.dgvMoradoresCadastrados.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLocacao);
            this.panel1.Controls.Add(this.btVeículo);
            this.panel1.Controls.Add(this.btObservacoes);
            this.panel1.Controls.Add(this.btVisitantes);
            this.panel1.Controls.Add(this.btDependentesCadastrados);
            this.panel1.Location = new System.Drawing.Point(853, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 637);
            this.panel1.TabIndex = 1;
            // 
            // btLocacao
            // 
            this.btLocacao.Location = new System.Drawing.Point(19, 75);
            this.btLocacao.Name = "btLocacao";
            this.btLocacao.Size = new System.Drawing.Size(85, 45);
            this.btLocacao.TabIndex = 4;
            this.btLocacao.Text = "Unidade Alguda";
            this.btLocacao.UseVisualStyleBackColor = true;
            this.btLocacao.Click += new System.EventHandler(this.btLocacao_Click);
            // 
            // btVeículo
            // 
            this.btVeículo.Location = new System.Drawing.Point(201, 12);
            this.btVeículo.Name = "btVeículo";
            this.btVeículo.Size = new System.Drawing.Size(85, 45);
            this.btVeículo.TabIndex = 3;
            this.btVeículo.Text = "Veículo";
            this.btVeículo.UseVisualStyleBackColor = true;
            this.btVeículo.Click += new System.EventHandler(this.btVeículo_Click);
            // 
            // btObservacoes
            // 
            this.btObservacoes.Location = new System.Drawing.Point(110, 75);
            this.btObservacoes.Name = "btObservacoes";
            this.btObservacoes.Size = new System.Drawing.Size(85, 45);
            this.btObservacoes.TabIndex = 2;
            this.btObservacoes.Text = "Observações";
            this.btObservacoes.UseVisualStyleBackColor = true;
            this.btObservacoes.Click += new System.EventHandler(this.btObservacoes_Click);
            // 
            // btVisitantes
            // 
            this.btVisitantes.Location = new System.Drawing.Point(110, 12);
            this.btVisitantes.Name = "btVisitantes";
            this.btVisitantes.Size = new System.Drawing.Size(85, 45);
            this.btVisitantes.TabIndex = 1;
            this.btVisitantes.Text = "Visitantes";
            this.btVisitantes.UseVisualStyleBackColor = true;
            this.btVisitantes.Click += new System.EventHandler(this.btVisitantes_Click);
            // 
            // btDependentesCadastrados
            // 
            this.btDependentesCadastrados.Location = new System.Drawing.Point(19, 12);
            this.btDependentesCadastrados.Name = "btDependentesCadastrados";
            this.btDependentesCadastrados.Size = new System.Drawing.Size(85, 45);
            this.btDependentesCadastrados.TabIndex = 0;
            this.btDependentesCadastrados.Text = "Dependentes";
            this.btDependentesCadastrados.UseVisualStyleBackColor = true;
            this.btDependentesCadastrados.Click += new System.EventHandler(this.btDependentesCadastrados_Click);
            // 
            // MoradoresCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMoradoresCadastrados);
            this.Name = "MoradoresCadastrados";
            this.Text = "Moradores Cadastrados";
            this.Load += new System.EventHandler(this.MoradoresCadastrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradoresCadastrados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoradoresCadastrados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btVeículo;
        private System.Windows.Forms.Button btObservacoes;
        private System.Windows.Forms.Button btVisitantes;
        private System.Windows.Forms.Button btDependentesCadastrados;
        private System.Windows.Forms.Button btLocacao;
    }
}