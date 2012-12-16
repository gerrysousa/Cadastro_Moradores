namespace Cadastro_Moradores_Condominio.Formulários
{
    partial class frmLista_Veiculos
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
            this.lstVVeiculos = new System.Windows.Forms.ListView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.veiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdProprietario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstVVeiculos
            // 
            this.lstVVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.veiculo,
            this.marca,
            this.modelo,
            this.cor,
            this.placa,
            this.ano,
            this.IdProprietario});
            this.lstVVeiculos.FullRowSelect = true;
            this.lstVVeiculos.GridLines = true;
            this.lstVVeiculos.Location = new System.Drawing.Point(12, 12);
            this.lstVVeiculos.Name = "lstVVeiculos";
            this.lstVVeiculos.Size = new System.Drawing.Size(569, 311);
            this.lstVVeiculos.TabIndex = 0;
            this.lstVVeiculos.UseCompatibleStateImageBehavior = false;
            this.lstVVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(23, 336);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 18;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(339, 336);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 17;
            this.btADD.Text = "Adicionar";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(422, 336);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 16;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(505, 336);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 34;
            // 
            // veiculo
            // 
            this.veiculo.Text = "Veiculo";
            this.veiculo.Width = 67;
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            this.marca.Width = 68;
            // 
            // modelo
            // 
            this.modelo.Text = "Modelo";
            this.modelo.Width = 120;
            // 
            // cor
            // 
            this.cor.Text = "Cor";
            // 
            // placa
            // 
            this.placa.Text = "Placa";
            // 
            // ano
            // 
            this.ano.Text = "Ano";
            this.ano.Width = 46;
            // 
            // IdProprietario
            // 
            this.IdProprietario.Text = "Id do Proprietario";
            this.IdProprietario.Width = 92;
            // 
            // frmLista_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 371);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lstVVeiculos);
            this.Name = "frmLista_Veiculos";
            this.Text = "frmLista_Veiculos";
            this.Load += new System.EventHandler(this.frmLista_Veiculos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVVeiculos;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader veiculo;
        private System.Windows.Forms.ColumnHeader marca;
        private System.Windows.Forms.ColumnHeader modelo;
        private System.Windows.Forms.ColumnHeader cor;
        private System.Windows.Forms.ColumnHeader placa;
        private System.Windows.Forms.ColumnHeader ano;
        private System.Windows.Forms.ColumnHeader IdProprietario;
    }
}