using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Moradores_Condominio;
using Cadastro_Moradores_Condominio.Formulários;

namespace Cadastro_Moradores_Condominio
{
    public partial class frmLista_Moradores : Form
    {
        public frmLista_Moradores()
        {
            InitializeComponent();
        }

        private void frmConsultaMoradorescs_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void ExcluirRegistro()
        {
            int id2 = 0;
            try
            {
                if (lstVMoradores.SelectedItems.Count > 0)
                {
                    id2 = Convert.ToInt32(lstVMoradores.SelectedItems[0].Text);

                    Morador objMorador = new Morador();

                    if (id2 > 0)
                    {
                        objMorador.Excluir(id2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
                //throw;
            }
        }

        private void EditarRegistro()
        {
            int ID;
            string Nome;
            string Predio;
            string Bloco;
            string Email;
            string Rg;
            string TelefoneResidencial;
            string TelefoneComercial;
            string Celular1;
            string Celular2;
            string Cpf;
            string Apartamento;
            int IDRespn;

            try
            {
                if (lstVMoradores.SelectedItems.Count > 0)
                {
                    ID = Convert.ToInt32(lstVMoradores.SelectedItems[0].Text);
                    Nome = lstVMoradores.SelectedItems[0].SubItems[1].Text;
                    Predio = lstVMoradores.SelectedItems[0].SubItems[2].Text;
                    Bloco = lstVMoradores.SelectedItems[0].SubItems[3].Text;
                    Email = lstVMoradores.SelectedItems[0].SubItems[4].Text;
                    Rg = lstVMoradores.SelectedItems[0].SubItems[5].Text;
                    TelefoneResidencial = lstVMoradores.SelectedItems[0].SubItems[6].Text;
                    TelefoneComercial = lstVMoradores.SelectedItems[0].SubItems[7].Text;
                    Celular1 = lstVMoradores.SelectedItems[0].SubItems[8].Text;
                    Celular2 = lstVMoradores.SelectedItems[0].SubItems[9].Text;
                    Cpf = lstVMoradores.SelectedItems[0].SubItems[10].Text;
                    IDRespn = Convert.ToInt32(lstVMoradores.SelectedItems[0].SubItems[11].Text);
                    Apartamento = lstVMoradores.SelectedItems[0].SubItems[12].Text;


                    frmCadastro_Moradores objFrmCadastro = new frmCadastro_Moradores();
                    objFrmCadastro.ID = ID;
                    objFrmCadastro.Nome = Nome;
                    objFrmCadastro.Predio = Predio;
                    objFrmCadastro.Bloco = Bloco;
                    objFrmCadastro.Email = Email;
                    objFrmCadastro.Rg = Rg;
                    objFrmCadastro.TelefoneResidencial = TelefoneResidencial;
                    objFrmCadastro.TelefoneComercial = TelefoneComercial;
                    objFrmCadastro.Celular1 = Celular1;
                    objFrmCadastro.Celular2 = Celular2;
                    objFrmCadastro.Cpf = Cpf;
                    objFrmCadastro.Apartamento = Apartamento;
                    objFrmCadastro.IDRespn = IDRespn;

                    objFrmCadastro.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }

        }

        private void CarregarListView()
        {
            Morador objMoradores = new Morador();
            List<Cadastro_Moradores_Condominio.Morador> lstMoradores = new List<Morador>();
            lstMoradores = objMoradores.Selecionar();

            lstVMoradores.Items.Clear();

            foreach (var itemLista in lstMoradores)
            {
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.Id.ToString();
                objListViewItem.SubItems.Add(itemLista.nome);
                objListViewItem.SubItems.Add(itemLista.predio);
                objListViewItem.SubItems.Add(itemLista.bloco);
                objListViewItem.SubItems.Add(itemLista.email);
                objListViewItem.SubItems.Add(itemLista.RG);
                objListViewItem.SubItems.Add(itemLista.telefoneResidencial);
                objListViewItem.SubItems.Add(itemLista.telefoneComercial);
                objListViewItem.SubItems.Add(itemLista.celular1);
                objListViewItem.SubItems.Add(itemLista.celular2);
                objListViewItem.SubItems.Add(itemLista.CPF);
                objListViewItem.SubItems.Add(itemLista.IdRespn.ToString());
                objListViewItem.SubItems.Add(itemLista.apartamento);

                lstVMoradores.Items.Add(objListViewItem);
            }

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
            CarregarListView();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
            CarregarListView();
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            frmCadastro_Moradores frmCadastro = new frmCadastro_Moradores();
            frmCadastro.ShowDialog();
            CarregarListView();
        }

        private void frmMoradoresCadastrados_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void btAtualizaLista_Click(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void btDependentesCadastrados_Click(object sender, EventArgs e)
        {
            frmLista_Dependentes objfrmDependentes = new frmLista_Dependentes();
            Dependente.IDTeste = -2;
            objfrmDependentes.ShowDialog();
           
        }

        private void btVisitantes_Click(object sender, EventArgs e)
        {
            frmLista_Visitantes objfrmVisitantes = new frmLista_Visitantes();
            Visitante.IDTeste = -2;
            objfrmVisitantes.ShowDialog();
        }

        private void btVeículo_Click(object sender, EventArgs e)
        {
            frmLista_Veiculos objfrmVeiculo = new frmLista_Veiculos();
            Veiculo.IDTeste = -2;
            objfrmVeiculo.ShowDialog();
        }

        private void btLocacao_Click(object sender, EventArgs e)
        {

        }

        private void btObservacoes_Click(object sender, EventArgs e)
        {

        }
    }
}