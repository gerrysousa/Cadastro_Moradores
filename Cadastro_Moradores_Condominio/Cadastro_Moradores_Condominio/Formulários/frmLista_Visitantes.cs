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
    public partial class frmLista_Visitantes : Form
    {
        public frmLista_Visitantes()
        {
            InitializeComponent();
        }

        public int IDTeste;

        private void frmLista_Visitantes_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            frmCadastro_Visitantes objFrmCadastro = new frmCadastro_Visitantes();
            objFrmCadastro.IdResponsavel = Visitante.IDTeste;
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

        private void CarregarListView()
        {
            Visitante objVisitantes = new Visitante();
            List<Cadastro_Moradores_Condominio.Visitante> lstVisitantes = new List<Visitante>();
           
            if (Visitante.IDTeste == -2)
            {
                lstVisitantes = objVisitantes.SelecionarTodos();
            }
            else
            {
                lstVisitantes = objVisitantes.Selecionar();
            }
            lstVVisitantes.Items.Clear();

            foreach (var itemLista in lstVisitantes)
            {
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.Id.ToString();
                objListViewItem.SubItems.Add(itemLista.nome);
                objListViewItem.SubItems.Add(itemLista.parentesco);
                objListViewItem.SubItems.Add(Convert.ToString(itemLista.IDResponsavel));

                lstVVisitantes.Items.Add(objListViewItem);
            }
        }

        private void ExcluirRegistro()
        {
            int id2 = 0;
            try
            {
                if (lstVVisitantes.SelectedItems.Count > 0)
                {
                    id2 = Convert.ToInt32(lstVVisitantes.SelectedItems[0].Text);

                    Visitante objVisitante = new Visitante();

                    if (id2 > 0)
                    {
                        objVisitante.Excluir(id2);
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
            int IDResponsavel;
            try
            {
                Id = Convert.ToInt32(lstVVisitantes.SelectedItems[0].Text);
                nome = lstVVisitantes.SelectedItems[0].SubItems[1].Text;
                parentesco = lstVVisitantes.SelectedItems[0].SubItems[2].Text;
                IDResponsavel = Convert.ToInt32(lstVVisitantes.SelectedItems[0].SubItems[3].Text);

                frmCadastro_Visitantes objFrmCadastro = new frmCadastro_Visitantes();
                //objFrmCadastro.IDteste = IDResponsavel;
                objFrmCadastro.ID2 = Id;
                objFrmCadastro.Nome = nome;
                objFrmCadastro.Parentesco = parentesco;
                objFrmCadastro.IdResponsavel = IDResponsavel;

                objFrmCadastro.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }

        }

      /*  private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (txtProcura.Text == string.Empty)
            {
                MessageBox.Show("Informe um nome!");
                    //alunosDataGridView.DataSource = alunosTableAdapter.GetData();
            }
            else
            {
                alunosDataGridView.DataSource = alunosTableAdapter.GetDataByNome("%" + txtNome.Text + "%");
            }
        }*/

    }
}
