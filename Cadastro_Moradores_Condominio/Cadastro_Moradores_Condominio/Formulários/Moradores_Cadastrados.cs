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

        public MoradoresCadastrados()
        {
            InitializeComponent();
        }

        private void frmConsultaMoradorescs_Load(object sender, EventArgs e)
        {
            //CarregarGridView();
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
                throw;
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
                Apartamento = lstVMoradores.SelectedItems[0].SubItems[11].Text;
                IDRespn = Convert.ToInt32(lstVMoradores.SelectedItems[12].SubItems[2].Text);


                Cadastro_Moradores objFrmCadastro = new Cadastro_Moradores();
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }

        }

        private void CarregarListView()
        {
            Morador objMoradores = new Morador();
            List<Cadastro_Moradores_Condominio.Morador> lstMoradores = new List<Cadastro_Moradores_Condominio.Morador>();
            lstMoradores = objMoradores.Selecionar();

            foreach (var itemLista in lstMoradores)
            {
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.ID.ToString();
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
                objListViewItem.SubItems.Add(itemLista.apartamento);
                objListViewItem.SubItems.Add(itemLista.IdRespn.ToString());

                lstVMoradores.Items.Add(objListViewItem);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }

        
    }
    /* List<Morador> lista_moradores = new List<Morador>();
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
     }*/
}

