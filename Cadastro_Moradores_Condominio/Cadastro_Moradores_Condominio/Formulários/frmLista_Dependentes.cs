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
    public partial class frmLista_Dependentes : Form
    {
        public frmLista_Dependentes()
        {
            InitializeComponent();
        }

        public int IDTeste;
        
        private void frmLista_Dependentes_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void CarregarListView()
        {
            Dependente objDependentes = new Dependente();
            List<Cadastro_Moradores_Condominio.Dependente> lstDependentes = new List<Dependente>();
            lstDependentes = objDependentes.Selecionar();

            lstVDependentes.Items.Clear();

            foreach (var itemLista in lstDependentes)
            {
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.Id.ToString();
                objListViewItem.SubItems.Add(itemLista.nome);
                objListViewItem.SubItems.Add(itemLista.parentesco);
                objListViewItem.SubItems.Add(itemLista.telefone);
                objListViewItem.SubItems.Add(Convert.ToString(itemLista.IDResponsavel));

                lstVDependentes.Items.Add(objListViewItem);
            }

        }

        private void ExcluirRegistro()
        {
            int id2 = 0;
            try
            {
                if (lstVDependentes.SelectedItems.Count > 0)
                {
                    id2 = Convert.ToInt32(lstVDependentes.SelectedItems[0].Text);

                    Dependente objDependente = new Dependente();

                    if (id2 > 0)
                    {
                        objDependente.Excluir(id2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
                throw;
            }
        }

        private void EditarRegistro()
        {
            int Id;
            string nome;
            string parentesco;
            string telefone;
            int IDResponsavel;
            try
            {
                Id = Convert.ToInt32(lstVDependentes.SelectedItems[0].Text);
                nome = lstVDependentes.SelectedItems[0].SubItems[1].Text;
                parentesco = lstVDependentes.SelectedItems[0].SubItems[2].Text;
                telefone = lstVDependentes.SelectedItems[0].SubItems[3].Text;
                IDResponsavel = Convert.ToInt32(lstVDependentes.SelectedItems[0].SubItems[4].Text);

                frmCadastro_Dependente objFrmCadastro = new frmCadastro_Dependente();
                //objFrmCadastro.IDteste = IDResponsavel;
                objFrmCadastro.ID2 = Id;
                objFrmCadastro.Nome = nome;
                objFrmCadastro.Parentesco = parentesco;
                objFrmCadastro.Telefone = telefone;
                objFrmCadastro.IdResponsavel = IDResponsavel;

                objFrmCadastro.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }

        }

        private void btADD_Click(object sender, EventArgs e)
        {
            frmCadastro_Dependente objFrmCadastro = new frmCadastro_Dependente();
            objFrmCadastro.IdResponsavel = Dependente.IDTeste;
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

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarListView();
        }
    }
}
