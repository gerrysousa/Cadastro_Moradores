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
    public partial class frmCadastro_Visitantes : Form
    {
        public frmCadastro_Visitantes()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtNome.Text))//&& !String.IsNullOrEmpty(txtID.Text))
                {
                    lbIdRespons.Text = Convert.ToString(Cadastro_Moradores_Condominio.Visitante.IDTeste);
                    if (ID2 == 0)
                    {  //( pID,  pNome,  pPredio,  pBloco,  pEmail,  pRg,  pTelefoneResidencial,  pTelefoneComercial,  pCelular1,  pCelular2,  pCpf,  pApartamento,  pIDRespn)                 
                        Gravar(Convert.ToInt32(txtID.Text), txtNome.Text, cbParentesco.Text, Convert.ToInt32(lbIdRespons.Text));
                    }
                    else
                    {
                        Atualizar(Convert.ToInt32(txtID.Text), txtNome.Text, cbParentesco.Text, Convert.ToInt32(lbIdRespons.Text));
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
                //throw;
            }
            Close();
        }

        private void frmCadastro_Visitantes_Load(object sender, EventArgs e)
        {
            if (ID2 > 0)
            {
                btSalvar.Text = "Atualizar";

                txtID.Text = ID2.ToString();
                txtNome.Text = Nome;
                cbParentesco.Text = Parentesco;
            }
            else
            {
                btSalvar.Text = "Salvar";
            }
        }

        #region variaveis publicas
        public int ID2 = 0;
        public string Nome;
        public string Parentesco;
        public int IdResponsavel;
        public ErrorProvider epErro;

        public int IDteste;
        #endregion

        public string SetTextolbIdRespons
        {
            set { lbIdRespons.Text = value; }
        }

        private void Gravar(int pID, string pNome, string pParentesco, int pIdResponsavel)
        {
            try
            {
                Visitante objVisitante = new Visitante();
                objVisitante.Salvar(pID, pNome, pParentesco, pIdResponsavel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
               // throw;
            }
        }

        private void Atualizar(int pID, string pNome, string pParentesco, int pIdResponsavel)
        {//int pID, 
            try
            {
                Visitante objVisitante = new Visitante();
                objVisitante.Atualizar(pID, pNome, pParentesco, pIdResponsavel);
                //pID,
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
               // throw;
            }
        }
    }
}
