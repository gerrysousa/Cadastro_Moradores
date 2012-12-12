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
    public partial class frmCadastroVeiculos : Form
    {
        string tipo;
        Veiculo veiculo;

        public frmCadastroVeiculos(Veiculo veiculo, string tipo)
        {
            this.tipo = tipo;
            this.veiculo = veiculo;
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            veiculo.Ano = mkbAno.Text;
            veiculo.Cor = cbCor.Text;
            veiculo.Marca = tbMarca.Text;
            veiculo.Modelo = tbModelo.Text;
            veiculo.Placa = tbPlaca.Text;
            veiculo.Carro = tbVeiculo.Text;
            this.Close();
        }

        private void CadastroVeiculos_Load(object sender, EventArgs e)
        {
            if (this.tipo == "exibicao")
            {
                btSalvar.Enabled = false;
                btSalvar.Visible = false;
                tbVeiculo.Text = veiculo.Carro;
                tbMarca.Text = veiculo.Marca;
                tbModelo.Text = veiculo.Modelo;
                tbPlaca.Text = veiculo.Placa;
                mkbAno.Text = veiculo.Ano;
                cbCor.Text = veiculo.Cor;
            }
        }        
    }
}
