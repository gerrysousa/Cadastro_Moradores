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
    public partial class frmCadastro_Dependente : Form
    {
        public frmCadastro_Dependente()
        {
            InitializeComponent();
        }

        #region variaveis publicas
        public int ID2 = 0;
        public string Nome;
        public string Parentesco;
        public string Telefone;
        public int IdResponsavel;
        public ErrorProvider epErro;

        public int IDteste;
        #endregion

        public string SetTextolbIdRespons
        {
            set { lbIdRespons.Text = value; }
        }

        private void Gravar(int pID, string pNome, string pParentesco, string pTelefone, int pIdResponsavel)
        {
            try
            {
                Dependente objDependente = new Dependente();
                objDependente.Salvar(pID, pNome, pParentesco, pTelefone, pIdResponsavel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                //throw;
            }
        }

        private void Atualizar(int pID, string pNome, string pParentesco, string pTelefone, int pIdResponsavel)
        {//int pID, 
            try
            {
                Dependente objDependente = new Dependente();
                objDependente.Atualizar(pID, pNome, pParentesco, pTelefone, pIdResponsavel);
                //pID,
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                //throw;
            }
        }

        private void frmCadastro_Dependentes_Load(object sender, EventArgs e)
        {
            lbIdRespons.Text = Convert.ToString(IdResponsavel);
            if (ID2 > 0)
            {
                btSalvar.Text = "Atualizar";

                txtID.Text = ID2.ToString();
                txtNome.Text = Nome;
                cbParentesco.Text = Parentesco;
                txtTelefone.Text = Telefone;
            }
            else
            {
                btSalvar.Text = "Salvar";
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtNome.Text))//&& !String.IsNullOrEmpty(txtID.Text))
                {
                    //lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Dependente.IDTeste);
                    if (ID2 == 0)
                    {  //( pID,  pNome,  pPredio,  pBloco,  pEmail,  pRg,  pTelefoneResidencial,  pTelefoneComercial,  pCelular1,  pCelular2,  pCpf,  pApartamento,  pIDRespn)                 
                        Gravar(Convert.ToInt32(txtID.Text), txtNome.Text, cbParentesco.Text, txtTelefone.Text, IdResponsavel);
                    }
                    else
                    {
                        //Atualizar(Convert.ToInt32(txtID.Text), txtNome.Text, cbParentesco.Text, txtTelefone.Text, Convert.ToInt32(lbIdRespons.Text));
                        Atualizar(Convert.ToInt32(txtID.Text), txtNome.Text, cbParentesco.Text, txtTelefone.Text, IdResponsavel);
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        epErro.SetError(txtID, "Informe o Codigo");
                    }
                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        epErro.SetError(txtNome, "Informe o Nome");
                    }
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
