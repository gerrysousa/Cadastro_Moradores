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
    public partial class MoradoresCadastrados : Form
    {
        List<Morador> lista_moradores = new List<Morador>();
        Morador morador;

        public MoradoresCadastrados(List<Morador> lista_moradores)
        {
            this.lista_moradores = lista_moradores;
            InitializeComponent();
        }

        private void MoradoresCadastrados_Load(object sender, EventArgs e)
        {
            dgvMoradoresCadastrados.Columns.Add("Morador", "Morador");
            dgvMoradoresCadastrados.Columns.Add("Predio", "Prédio");
            dgvMoradoresCadastrados.Columns.Add("Apartamento", "Apartamento");
            dgvMoradoresCadastrados.Columns.Add("Bloco", "Bloco");
            dgvMoradoresCadastrados.Columns.Add("TelefoneRes", "Telefone Residencial");
            dgvMoradoresCadastrados.Columns.Add("TelefoneCom", "Telefone Comercial");
            dgvMoradoresCadastrados.Columns.Add("Celular1", "Celular");
            dgvMoradoresCadastrados.Columns.Add("Celular2", "Celular");
            dgvMoradoresCadastrados.Columns.Add("Email", "Email");
            dgvMoradoresCadastrados.Columns.Add("Rg", "Doc. Identidade");
            dgvMoradoresCadastrados.Columns.Add("Cpf", "Cpf");
            dgvMoradoresCadastrados.Columns["Morador"].Width = 150;
            dgvMoradoresCadastrados.Columns["Email"].Width = 120;

            foreach (Morador morador in lista_moradores)
            {
                dgvMoradoresCadastrados.Rows.Add(morador.Nome, morador.Predio, morador.Apartamento, morador.Bloco, morador.DddResidencial + morador.TelefoneResidencial, morador.DddComercial + morador.TelefoneComercial, morador.DddCelular1 + morador.Celular1, morador.DddCelular2 + morador.Celular2, morador.Email, morador.Rg, morador.Cpf);
            }
        }

        private void btDependentesCadastrados_Click(object sender, EventArgs e)
        {
            morador = new Morador();
            string nome_morador;
            nome_morador = dgvMoradoresCadastrados.SelectedRows[0].Cells[0].Value.ToString();

            foreach (Morador mor in lista_moradores)
            {
                if (mor.Nome == nome_morador)
                    morador = mor;
            }

            Cadastro_Depententes cad = new Cadastro_Depententes(morador.Dependente, "exibicao");
            cad.ShowDialog();
        }

        private void btLocacao_Click(object sender, EventArgs e)
        {
            morador = new Morador();
            string nome_morador;
            nome_morador = dgvMoradoresCadastrados.SelectedRows[0].Cells[0].Value.ToString();

            foreach (Morador mor in lista_moradores)
            {
                if (mor.Nome == nome_morador)
                    morador = mor;
            }
            if (morador.Locacao.UnidadeAlugada == false)
            {
                MessageBox.Show("Proprietário do Imóvel","Info");
            }
            else
            {
                CadastroLocacao cad = new CadastroLocacao(morador.Locacao, "exibicao");
                cad.ShowDialog();
            }
        }

        private void btObservacoes_Click(object sender, EventArgs e)
        {
            morador = new Morador();
            string nome_morador;
            nome_morador = dgvMoradoresCadastrados.SelectedRows[0].Cells[0].Value.ToString();

            foreach (Morador mor in lista_moradores)
            {
                if (mor.Nome == nome_morador)
                    morador = mor;
            }
            CadastroObservacoes cad = new CadastroObservacoes(morador.Observacao, "exibicao");
            cad.ShowDialog();
        }

        private void btVeículo_Click(object sender, EventArgs e)
        {
            morador = new Morador();
            string nome_morador;
            nome_morador = dgvMoradoresCadastrados.SelectedRows[0].Cells[0].Value.ToString();

            foreach (Morador mor in lista_moradores)
            {
                if (mor.Nome == nome_morador)
                    morador = mor;
            }
            CadastroVeiculos cad = new CadastroVeiculos(morador.Veiculo, "exibicao");
            cad.ShowDialog();
        }

        private void btVisitantes_Click(object sender, EventArgs e)
        {
            morador = new Morador();
            string nome_morador;
            nome_morador = dgvMoradoresCadastrados.SelectedRows[0].Cells[0].Value.ToString();

            foreach (Morador mor in lista_moradores)
            {
                if (mor.Nome == nome_morador)
                    morador = mor;
            }

            Cadastro_Visitantes cad = new Cadastro_Visitantes(morador.Visitante, "exibicao");
            cad.ShowDialog();
        }
    }
}
