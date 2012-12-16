using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Moradores_Condominio;

namespace Cadastro_Moradores_Condominio
{
    public partial class frmCadastro_Veiculos : Form
    {
        public frmCadastro_Veiculos()
        {
            InitializeComponent();
        }

        #region variaveis publicas
        public int ID2 = 0;
        public string Veiculo;
        public string Marca;
        public string Modelo;
        public string Cor;
        public string Placa;
        public string Ano;
        public int IdProprietario;
        public ErrorProvider epErro;
        public int IDteste;
        #endregion

        public string SetTextolbIdProprietario
        {
            set { lbIdProprietario.Text = value; }
        }

        private void Gravar(int pID, string pVeiculo, string pMarca, string pModelo, string pCor, string pPlaca, string pAno, int pIdProprietario)
        {
            try
            {
                Veiculo objVeiculo = new Veiculo();
                objVeiculo.Salvar(pID, pVeiculo, pMarca, pModelo, pCor, pPlaca, pAno, pIdProprietario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
                throw;
            }
        }

        private void Atualizar(int pID, string pVeiculo, string pMarca, string pModelo, string pCor, string pPlaca, string pAno, int pIdProprietario)
        {
            try
            {
                Veiculo objVeiculo = new Veiculo();
                objVeiculo.Atualizar(pID, pVeiculo, pMarca, pModelo, pCor, pPlaca, pAno, pIdProprietario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
                throw;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroVeiculos_Load(object sender, EventArgs e)
        {
            if (ID2 > 0)
            {
                btSalvar.Text = "Atualizar";

                txtID.Text = ID2.ToString();
                txtVeiculo.Text = Veiculo;
                txtMarca.Text = Marca;
                txtModelo.Text = Modelo;
                txtCor.Text = Cor;
                txtPlaca.Text = Placa;
                txtAno.Text = Ano;
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
                if (!String.IsNullOrEmpty(txtVeiculo.Text))//&& !String.IsNullOrEmpty(txtID.Text))
                {
                    lbIdProprietario.Text = Convert.ToString(Cadastro_Moradores_Condominio.Veiculo.IDTeste);//IdProprietario
                    if (ID2 == 0)
                    {  //( pID,  pVeiculo, Ca pPredio,  pBloco,  pEmail,  pRg,  pModeloResidencial,  pModeloComercial,  pCelular1,  pCelular2,  pCpf,  pApartamento,  pIDRespn)                 
                        Gravar(Convert.ToInt32(txtID.Text), txtVeiculo.Text, txtMarca.Text, txtModelo.Text, txtCor.Text, txtPlaca.Text, txtAno.Text, Convert.ToInt32(lbIdProprietario.Text));
                    }
                    else
                    {
                        Atualizar(Convert.ToInt32(txtID.Text), txtVeiculo.Text, txtMarca.Text, txtModelo.Text, txtCor.Text, txtPlaca.Text, txtAno.Text, Convert.ToInt32(lbIdProprietario.Text));
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        epErro.SetError(txtID, "Informe o Codigo");
                    }
                    if (String.IsNullOrEmpty(txtVeiculo.Text))
                    {
                        epErro.SetError(txtVeiculo, "Informe o Veiculo");
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


    }
}
