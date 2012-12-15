namespace Cadastro_Moradores_Condominio.Formulários
{
    partial class frmLista_Dependentes
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
            this.lstVDependentes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentesco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDResponsavel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVDependentes
            // 
            this.lstVDependentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nome,
            this.parentesco,
            this.telefone,
            this.IDResponsavel});
            this.lstVDependentes.FullRowSelect = true;
            this.lstVDependentes.GridLines = true;
            this.lstVDependentes.Location = new System.Drawing.Point(12, 12);
            this.lstVDependentes.Name = "lstVDependentes";
            this.lstVDependentes.Size = new System.Drawing.Size(605, 312);
            this.lstVDependentes.TabIndex = 0;
            this.lstVDependentes.UseCompatibleStateImageBehavior = false;
            this.lstVDependentes.View = System.Windows.Forms.View.Details;
           // this.lstVDependentes.SelectedIndexChanged += new System.EventHandler(this.lstVDependentes_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 48;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 235;
            // 
            // parentesco
            // 
            this.parentesco.Text = "Parentesco";
            this.parentesco.Width = 92;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.Width = 124;
            // 
            // IDResponsavel
            // 
            this.IDResponsavel.Text = "ID Responsavel";
            this.IDResponsavel.Width = 90;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(525, 330);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(442, 330);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 12;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(359, 330);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 13;
            this.btADD.Text = "Adicionar";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(43, 330);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 14;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // frmLista_Dependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 364);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lstVDependentes);
            this.Name = "frmLista_Dependentes";
            this.Text = "Lista de Dependentes";
            this.Load += new System.EventHandler(this.frmLista_Dependentes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVDependentes;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader parentesco;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader IDResponsavel;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btAtualizar;
    }
}