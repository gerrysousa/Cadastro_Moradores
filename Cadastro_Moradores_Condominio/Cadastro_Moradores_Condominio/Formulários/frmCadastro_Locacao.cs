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
    public partial class frmCadastro_Locacao : Form
    {
        public frmCadastro_Locacao()
        {
            InitializeComponent();
        }

        #region variaveis publicas
        public string UnidadeAlocada;
        public string NomeProprietario;
        public string FoneProprietario;
        public string NomeImobiliaria;
        public string FoneImobiliaria;
        public int IdResponsavel;
        public ErrorProvider epErro;
        public int IDteste;
        #endregion

        
        public string SetTextolbIdRespons
        {
            set { lbIdRespons.Text = value; }
        }

        private void Gravar(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria, int pIdResponsavel)
        {
            try
            {
                Locacao objLocacao = new Locacao();
                objLocacao.Salvar(pUnidadeAlocada, pNomeProprietario, pFoneProprietario, pNomeImobiliaria, pFoneImobiliaria, pIdResponsavel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                throw;
            }
        }

        private void Atualizar(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria, int pIdResponsavel)
        {
            try
            {
                Locacao objLocacao = new Locacao();
                objLocacao.Atualizar(pUnidadeAlocada, pNomeProprietario, pFoneProprietario, pNomeImobiliaria, pFoneImobiliaria, pIdResponsavel);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                throw;
            }
        }

        

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string strUnidadeAlocada = string.Empty;
                lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Locacao.IDTeste);
                if (rbSim.Checked)
                {
                    strUnidadeAlocada = "Sim";
                }
                else
                    strUnidadeAlocada = "Nao";
                /* lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Locacao.IDTeste);
                 if (lbIdRespons.Text == "0")
                 {*/
                     Gravar(strUnidadeAlocada, txtNomeProprietario.Text,txtFoneProprietario.Text, txtImobiliaria.Text,txtFoneImobiliaria.Text, Convert.ToInt32(lbIdRespons.Text));
                /* }
                 else
                 {*/
               // Atualizar(strUnidadeAlocada, txtNomeProprietario.Text, txtFoneProprietario.Text, txtImobiliaria.Text, txtFoneImobiliaria.Text, Convert.ToInt32(lbIdRespons.Text));
                //}(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria, int pIdResponsavel)
                MessageBox.Show("Operação realizada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
                throw;
            }
            Close();
        }

        private void frmCadastro_Locacao_Load(object sender, EventArgs e)
        {
            Locacao objLocacao = new Locacao();
            //txtLocacao.Text = 
            objLocacao = objLocacao.SelecionarLocacao(Locacao.IDTeste);//Convert.ToInt32(lbIdRespons.Text)
            txtFoneImobiliaria.Text = objLocacao.foneImobiliaria;
            txtFoneProprietario.Text = objLocacao.foneProprietario;
            txtImobiliaria.Text = objLocacao.nomeImobiliaria;
            txtNomeProprietario.Text = objLocacao.nomeProprietario;

            if (objLocacao.unidadeAlocada.Equals("Sim"))
            {
                rbSim.Checked = true;
            }
            else
            {
                rbNao.Checked = true;
            }
        }


    }
}
