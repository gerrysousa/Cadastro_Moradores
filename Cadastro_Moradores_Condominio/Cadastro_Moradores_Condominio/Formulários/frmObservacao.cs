using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro_Moradores_Condominio.Formulários
{
    public partial class frmObservacao : Form
    {
        public frmObservacao()
        {
            InitializeComponent();
        }

        #region variaveis publicas
        public int ID2 = 0;
        public int IdResponsavel;
        public string Observacaov;
        public ErrorProvider epErro;
        public int IDteste;
        #endregion

        private void frmObservacao_Load(object sender, EventArgs e)
        {
            Observacao objObservacao = new Observacao();
            txtObservacao.Text = objObservacao.BuscaObservacao(Observacao.IDTeste);//Convert.ToInt32(lbIdRespons.Text)
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Observacao.IDTeste);
                if (lbIdRespons.Text == "0")
                {
                    Gravar(Convert.ToInt32(lbIdRespons.Text), txtObservacao.Text);
                }
                else
                {
                    Atualizar(Convert.ToInt32(lbIdRespons.Text), txtObservacao.Text);
                }
                MessageBox.Show("Operação realizada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
                throw;
            }
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string SetTextolbIdRespons
        {
            set { lbIdRespons.Text = value; }
        }

        private void Gravar(int pIdResponsavel, string pObservacao)
        {
            try
            {
                Observacao objObservacao = new Observacao();
                objObservacao.Salvar(pIdResponsavel, pObservacao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                throw;
            }
        }

        private void Atualizar(int pIdResponsavel, string pObservacao)
        {
            try
            {
                Observacao objObservacao = new Observacao();
                objObservacao.Atualizar(pIdResponsavel, pObservacao);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                throw;
            }
        }

    }
}

