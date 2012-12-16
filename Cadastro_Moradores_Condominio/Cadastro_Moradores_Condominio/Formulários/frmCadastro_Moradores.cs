using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Moradores_Condominio.Formulários;


namespace Cadastro_Moradores_Condominio
{
    public partial class frmCadastro_Moradores : Form
    {
        public frmCadastro_Moradores()
        {
            InitializeComponent();
        }

        #region variaveis publicas
        public int ID = 0;

        public string Nome;
        public string Predio;
        public string Bloco;
        public string Email;
        public string Rg;
        public string TelefoneResidencial;
        public string TelefoneComercial;
        public string Celular1;
        public string Celular2;
        public string Cpf;
        public string Apartamento;
        public int IDRespn;

        public ErrorProvider epErro;
        #endregion

        private void Gravar(int pID, string pNome, string pPredio, string pBloco, string pEmail, string pRg, string pTelefoneResidencial, string pTelefoneComercial, string pCelular1, string pCelular2, string pCpf, string pApartamento, int pIDRespn)
        {
            try
            {
                Morador objMorador = new Morador();
                objMorador.Salvar(pID, pNome, pPredio, pBloco, pEmail, pRg, pTelefoneResidencial, pTelefoneComercial, pCelular1, pCelular2, pCpf, pApartamento, pIDRespn);
                //MessageBox.Show("Inserido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                throw;
            }
        }

        private void Atualizar(int pID, string pNome, string pPredio, string pBloco, string pEmail, string pRg, string pTelefoneResidencial, string pTelefoneComercial, string pCelular1, string pCelular2, string pCpf, string pApartamento, int pIDRespn)
        {
            try
            {
                Morador objMorador = new Morador();
                objMorador.Atualizar(pID, pNome, pPredio, pBloco, pEmail, pRg, pTelefoneResidencial, pTelefoneComercial, pCelular1, pCelular2, pCpf, pApartamento, pIDRespn);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                throw;
            }
        }

        private void frmCadastro_Moradores_Load(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                btSalvar.Text = "Atualizar";


                txtID.Text = ID.ToString();
                txtNome.Text = Nome;

                cbPredio.Text = Predio;
                cbBloco.Text = Bloco;
                txtEmail.Text = Email;
                txtIdentidade.Text = Rg;
                mbTelefoneResidencial.Text = TelefoneResidencial;
                mbTelefoneComercial.Text = TelefoneComercial;
                mbCelular1.Text = Celular1;
                mbCelular2.Text = Celular2;
                mbCpf.Text = Cpf;
                txtApartamento.Text = Apartamento;
                txtIDRespn.Text = IDRespn.ToString();
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
                if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtApartamento.Text))
                {
                    if (ID == 0)
                    {  //( pID,  pNome,  pPredio,  pBloco,  pEmail,  pRg,  pTelefoneResidencial,  pTelefoneComercial,  pCelular1,  pCelular2,  pCpf,  pApartamento,  pIDRespn)                 
                        Gravar(Convert.ToInt32(txtID.Text), txtNome.Text, cbPredio.Text, cbBloco.Text, txtEmail.Text, txtIdentidade.Text, mbTelefoneResidencial.Text, mbTelefoneComercial.Text, mbCelular1.Text, mbCelular2.Text, mbCpf.Text, txtApartamento.Text, Convert.ToInt32(txtIDRespn.Text));
                    }
                    else
                    {
                        Atualizar(Convert.ToInt32(txtID.Text), txtNome.Text, cbPredio.Text, cbBloco.Text, txtEmail.Text, txtIdentidade.Text, mbTelefoneResidencial.Text, mbTelefoneComercial.Text, mbCelular1.Text, mbCelular2.Text, mbCpf.Text, txtApartamento.Text, Convert.ToInt32(txtIDRespn.Text));
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
                throw;
            }
            Close();
        }

        private void btCadastroDependentes_Click(object sender, EventArgs e)
        {
            // frmCadastro_Dependente objfrmDependentes = new frmCadastro_Dependente();
            frmLista_Dependentes objfrmDependentes = new frmLista_Dependentes();
            //Dependente objTeste = new Dependente();
            Dependente.IDTeste = Convert.ToInt32(txtID.Text);
            objfrmDependentes.ShowDialog();
        }

        private void btCadastroVeiculos_Click(object sender, EventArgs e)
        {
            frmLista_Veiculos objfrmVeiculo = new frmLista_Veiculos();
            Veiculo.IDTeste = Convert.ToInt32(txtID.Text);
            objfrmVeiculo.ShowDialog();
        }

        private void btCadastroVisitantes_Click(object sender, EventArgs e)
        {
            frmLista_Visitantes objfrmVisitantes = new frmLista_Visitantes();
            Visitante.IDTeste = Convert.ToInt32(txtID.Text);
            objfrmVisitantes.ShowDialog();
        }
    }
}
