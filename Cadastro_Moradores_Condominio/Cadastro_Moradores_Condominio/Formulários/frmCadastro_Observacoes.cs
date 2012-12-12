using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro_Moradores_Condominio
{
    public partial class frmCadastroObservacoes : Form
    {
        string tipo;
        Observacao observacao;

        public frmCadastroObservacoes(Observacao observacao, string tipo)
        {
            this.tipo = tipo;
            this.observacao = observacao;
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            observacao.Texto = rtbObservacoes.Text;
            this.Close();
        }

        private void CadastroObservacoes_Load(object sender, EventArgs e)
        {
            if (this.tipo == "exibicao")
            {
                btSalvar.Enabled = false;
                btSalvar.Visible = false;
                rtbObservacoes.Text = observacao.Texto;
            }
        }
    }
}
