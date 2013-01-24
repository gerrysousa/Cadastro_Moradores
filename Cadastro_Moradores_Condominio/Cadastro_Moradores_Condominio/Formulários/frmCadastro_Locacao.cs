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
        public int SalvarOuEditar;//se 1 chamar Gravar , se 2 chamar Atualizar
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
               // throw;
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
               // throw;
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
                if ((rbNao.Checked = false) && (rbSim.Checked = false))//&& !String.IsNullOrEmpty(txtID.Text))
                {
                    epErro.SetError(gbLocacao, "Informe se a unidade é alugada!");
                }
                else
                {
                    string strUnidadeAlocada = string.Empty;
                    //lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Locacao.IDTeste);
                    if (rbSim.Checked)
                    {
                        strUnidadeAlocada = "Sim";
                    }
                    else
                    {
                        strUnidadeAlocada = "Nao";

                    }

                    /* lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Locacao.IDTeste);
                     if ((rbNao.Checked=false)&&(rbSim.Checked=false))
                     {*/
                    if (SalvarOuEditar == 1)
                    {
                        Gravar(strUnidadeAlocada, txtNomeProprietario.Text, txtFoneProprietario.Text, txtImobiliaria.Text, txtFoneImobiliaria.Text, IdResponsavel);
                    }
                    else
                    {
                        Atualizar(strUnidadeAlocada, txtNomeProprietario.Text, txtFoneProprietario.Text, txtImobiliaria.Text, txtFoneImobiliaria.Text, IdResponsavel);
                    }
                    //(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria, int pIdResponsavel)

                }
                MessageBox.Show("Operação realizada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
               // throw;
            }
            Close();
        }

        private void frmCadastro_Locacao_Load(object sender, EventArgs e)
        {

            Locacao objLocacao = new Locacao();
            objLocacao = objLocacao.SelecionarLocacao(Locacao.IDTeste);//Convert.ToInt32(lbIdRespons.Text)
            txtFoneImobiliaria.Text = objLocacao.foneImobiliaria;
            txtFoneProprietario.Text = objLocacao.foneProprietario;
            txtImobiliaria.Text = objLocacao.nomeImobiliaria;
            txtNomeProprietario.Text = objLocacao.nomeProprietario;
           // lbIdRespons.Text = Convert.ToString(objLocacao.IDResponsavel);
            lbIdRespons.Text = Convert.ToString(IdResponsavel);

            if (txtNomeProprietario.Text=="")
            {
                btSalvar.Text = "Salvar";
                SalvarOuEditar = 1;
            }
           
            if (objLocacao.unidadeAlocada.Equals("Sim"))
            {
                rbSim.Checked = true;
                SalvarOuEditar = 2;
                btSalvar.Text = "Atualizar";
            }
            else if (objLocacao.unidadeAlocada.Equals("Nao"))
            {
                rbNao.Checked = true;
                SalvarOuEditar = 2;
                btSalvar.Text = "Atualizar";
            }

            else//((rbNao.Checked = false) && (rbSim.Checked = false))
            {
                btSalvar.Text = "Salvar";
                SalvarOuEditar = 1;
            }            
        }
    }
}

