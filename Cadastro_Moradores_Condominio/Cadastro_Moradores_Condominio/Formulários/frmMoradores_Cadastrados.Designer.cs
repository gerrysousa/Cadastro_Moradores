namespace Cadastro_Moradores_Condominio
{
    partial class frmMoradoresCadastrados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLocacao = new System.Windows.Forms.Button();
            this.btVeículo = new System.Windows.Forms.Button();
            this.btObservacoes = new System.Windows.Forms.Button();
            this.btVisitantes = new System.Windows.Forms.Button();
            this.btDependentesCadastrados = new System.Windows.Forms.Button();
            this.lstVMoradores = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.predio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bloco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foneResidencial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foneComercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.celular1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.celular2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDResponsavel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.btAtualizaLista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLocacao);
            this.panel1.Controls.Add(this.btVeículo);
            this.panel1.Controls.Add(this.btObservacoes);
            this.panel1.Controls.Add(this.btVisitantes);
            this.panel1.Controls.Add(this.btDependentesCadastrados);
            this.panel1.Location = new System.Drawing.Point(865, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 487);
            this.panel1.TabIndex = 1;
            // 
            // btLocacao
            // 
            this.btLocacao.Location = new System.Drawing.Point(19, 75);
            this.btLocacao.Name = "btLocacao";
            this.btLocacao.Size = new System.Drawing.Size(85, 45);
            this.btLocacao.TabIndex = 4;
            this.btLocacao.Text = "Unidade Alugada?";
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
            // lstVMoradores
            // 
            this.lstVMoradores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nome,
            this.predio,
            this.bloco,
            this.email,
            this.RG,
            this.foneResidencial,
            this.foneComercial,
            this.celular1,
            this.celular2,
            this.cpf,
            this.IDResponsavel,
            this.apartamento});
            this.lstVMoradores.FullRowSelect = true;
            this.lstVMoradores.GridLines = true;
            this.lstVMoradores.Location = new System.Drawing.Point(12, 13);
            this.lstVMoradores.Name = "lstVMoradores";
            this.lstVMoradores.Size = new System.Drawing.Size(847, 413);
            this.lstVMoradores.TabIndex = 2;
            this.lstVMoradores.UseCompatibleStateImageBehavior = false;
            this.lstVMoradores.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Codigo";
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            // 
            // predio
            // 
            this.predio.Text = "Predio";
            // 
            // bloco
            // 
            this.bloco.Text = "Bloco";
            // 
            // email
            // 
            this.email.Text = "Email";
            // 
            // RG
            // 
            this.RG.Text = "Identidade";
            // 
            // foneResidencial
            // 
            this.foneResidencial.Text = "Telefone  Residencial";
            // 
            // foneComercial
            // 
            this.foneComercial.Text = "Telefone Comercial";
            this.foneComercial.Width = 89;
            // 
            // celular1
            // 
            this.celular1.Text = "Celular1";
            // 
            // celular2
            // 
            this.celular2.Text = "Celular2";
            // 
            // cpf
            // 
            this.cpf.Text = "CPF";
            this.cpf.Width = 74;
            // 
            // IDResponsavel
            // 
            this.IDResponsavel.Text = "Responsavel";
            this.IDResponsavel.Width = 81;
            // 
            // apartamento
            // 
            this.apartamento.Text = "Apartamento";
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(94, 449);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(175, 449);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(13, 449);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 5;
            this.btADD.Text = "Adicionar";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btAtualizaLista
            // 
            this.btAtualizaLista.Location = new System.Drawing.Point(720, 452);
            this.btAtualizaLista.Name = "btAtualizaLista";
            this.btAtualizaLista.Size = new System.Drawing.Size(75, 23);
            this.btAtualizaLista.TabIndex = 6;
            this.btAtualizaLista.Text = "Refresh";
            this.btAtualizaLista.UseVisualStyleBackColor = true;
            this.btAtualizaLista.Click += new System.EventHandler(this.btAtualizaLista_Click);
            // 
            // frmMoradoresCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 487);
            this.Controls.Add(this.btAtualizaLista);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.lstVMoradores);
            this.Controls.Add(this.panel1);
            this.Name = "frmMoradoresCadastrados";
            this.Text = "Moradores Cadastrados";
            this.Load += new System.EventHandler(this.frmMoradoresCadastrados_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btVeículo;
        private System.Windows.Forms.Button btObservacoes;
        private System.Windows.Forms.Button btVisitantes;
        private System.Windows.Forms.Button btDependentesCadastrados;
        private System.Windows.Forms.Button btLocacao;
        private System.Windows.Forms.ListView lstVMoradores;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader predio;
        private System.Windows.Forms.ColumnHeader bloco;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader RG;
        private System.Windows.Forms.ColumnHeader foneResidencial;
        private System.Windows.Forms.ColumnHeader foneComercial;
        private System.Windows.Forms.ColumnHeader celular1;
        private System.Windows.Forms.ColumnHeader celular2;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader IDResponsavel;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btAtualizaLista;
        private System.Windows.Forms.ColumnHeader apartamento;
    }
}