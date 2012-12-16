namespace Cadastro_Moradores_Condominio.Formulários
{
    partial class frmLista_Visitantes
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
            this.lstVVisitantes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentesco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDResponsavel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVVisitantes
            // 
            this.lstVVisitantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nome,
            this.parentesco,
            this.IDResponsavel});
            this.lstVVisitantes.FullRowSelect = true;
            this.lstVVisitantes.GridLines = true;
            this.lstVVisitantes.Location = new System.Drawing.Point(12, 12);
            this.lstVVisitantes.Name = "lstVVisitantes";
            this.lstVVisitantes.Size = new System.Drawing.Size(578, 312);
            this.lstVVisitantes.TabIndex = 1;
            this.lstVVisitantes.UseCompatibleStateImageBehavior = false;
            this.lstVVisitantes.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 48;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 330;
            // 
            // parentesco
            // 
            this.parentesco.Text = "Parentesco";
            this.parentesco.Width = 92;
            // 
            // IDResponsavel
            // 
            this.IDResponsavel.Text = "ID Responsavel";
            this.IDResponsavel.Width = 94;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(24, 348);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 18;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(340, 348);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 17;
            this.btADD.Text = "Adicionar";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(423, 348);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 16;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(506, 348);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // frmLista_Visitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 383);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lstVVisitantes);
            this.Name = "frmLista_Visitantes";
            this.Text = "Lista de Visitantes";
            this.Load += new System.EventHandler(this.frmLista_Visitantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVVisitantes;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader parentesco;
        private System.Windows.Forms.ColumnHeader IDResponsavel;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
    }
}