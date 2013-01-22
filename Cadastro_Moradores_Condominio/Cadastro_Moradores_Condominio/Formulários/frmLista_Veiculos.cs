using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Moradores_Condominio;

namespace Cadastro_Moradores_Condominio.Formulários
{
    public partial class frmLista_Veiculos : Form
    {
        public frmLista_Veiculos()
        {
            InitializeComponent();
        }
        public int IDTeste;

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            frmCadastro_Veiculos objFrmCadastro = new frmCadastro_Veiculos();
            objFrmCadastro.IdProprietario = Veiculo.IDTeste;
            objFrmCadastro.ShowDialog();
            CarregarListView();
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

        private void frmLista_Veiculos_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void CarregarListView()
        {
            Veiculo objVeiculos = new Veiculo();
            List<Cadastro_Moradores_Condominio.Veiculo> lstVeiculos = new List<Veiculo>();

            if (Veiculo.IDTeste == -2)
            {
                lstVeiculos = objVeiculos.SelecionarTodos(); 
            }
            else
            {
                lstVeiculos = objVeiculos.Selecionar();
            }
            lstVVeiculos.Items.Clear();

            foreach (var itemLista in lstVeiculos)
            {//(ID, Veiculo, Marca, Modelo, Cor, Placa, Ano, IdProprietario)
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.Id.ToString();
                objListViewItem.SubItems.Add(itemLista.veiculo);
                objListViewItem.SubItems.Add(itemLista.marca);
                objListViewItem.SubItems.Add(itemLista.modelo);
                objListViewItem.SubItems.Add(itemLista.cor);
                objListViewItem.SubItems.Add(itemLista.placa);
                objListViewItem.SubItems.Add(itemLista.ano);
                objListViewItem.SubItems.Add(Convert.ToString(itemLista.IDProprietario));

                lstVVeiculos.Items.Add(objListViewItem);
            }
        }

        private void ExcluirRegistro()
        {
            int id2 = 0;
            try
            {
                if (lstVVeiculos.SelectedItems.Count > 0)
                {
                    id2 = Convert.ToInt32(lstVVeiculos.SelectedItems[0].Text);

                    Veiculo objVeiculo = new Veiculo();

                    if (id2 > 0)
                    {
                        objVeiculo.Excluir(id2);
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
            int Id;
            string veiculo;
            string marca;
            string modelo;
            string cor;
            string placa;
            string ano;
            int IDProprietario;

            try
            {
                Id = Convert.ToInt32(lstVVeiculos.SelectedItems[0].Text);
                veiculo = lstVVeiculos.SelectedItems[0].SubItems[1].Text;
                marca = lstVVeiculos.SelectedItems[0].SubItems[2].Text;
                modelo = lstVVeiculos.SelectedItems[0].SubItems[3].Text;
                cor = lstVVeiculos.SelectedItems[0].SubItems[4].Text;
                placa = lstVVeiculos.SelectedItems[0].SubItems[5].Text;
                ano = lstVVeiculos.SelectedItems[0].SubItems[6].Text;
                IDProprietario = Convert.ToInt32(lstVVeiculos.SelectedItems[0].SubItems[7].Text);

                frmCadastro_Veiculos objFrmCadastro = new frmCadastro_Veiculos();
                objFrmCadastro.ID2 = Id;
                objFrmCadastro.Veiculo = veiculo;
                objFrmCadastro.Marca = marca;
                objFrmCadastro.Modelo = modelo;
                objFrmCadastro.Cor = cor;
                objFrmCadastro.Placa = placa;
                objFrmCadastro.Ano = ano;
                objFrmCadastro.IdProprietario = IDProprietario;

                objFrmCadastro.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Veiculo objVeiculos = new Veiculo();
            List<Cadastro_Moradores_Condominio.Veiculo> lstVeiculos = new List<Veiculo>();

            if (txtProcura.Text == string.Empty)
            {
                MessageBox.Show("Informe uma Placa!");
            }
            else
            {
                lstVeiculos = objVeiculos.SelecionarPorPlaca(txtProcura.Text);
            }
            lstVVeiculos.Items.Clear();

            foreach (var itemLista in lstVeiculos)
            {//(ID, Veiculo, Marca, Modelo, Cor, Placa, Ano, IdProprietario)
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.Id.ToString();
                objListViewItem.SubItems.Add(itemLista.veiculo);
                objListViewItem.SubItems.Add(itemLista.marca);
                objListViewItem.SubItems.Add(itemLista.modelo);
                objListViewItem.SubItems.Add(itemLista.cor);
                objListViewItem.SubItems.Add(itemLista.placa);
                objListViewItem.SubItems.Add(itemLista.ano);
                objListViewItem.SubItems.Add(Convert.ToString(itemLista.IDProprietario));

                lstVVeiculos.Items.Add(objListViewItem);
            }
        }
    }
}
