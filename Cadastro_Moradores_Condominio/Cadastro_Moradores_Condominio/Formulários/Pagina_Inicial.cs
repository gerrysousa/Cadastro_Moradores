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
    public partial class Pagina_Inicial : Form
    {
        private List<Morador> lista_moradores = new List<Morador>();
        public Pagina_Inicial()
        {
            InitializeComponent();
        }

        //private void btCadastrarMoradores_Click(object sender, EventArgs e)
        //{
        //    Cadastro_Moradores cad = new Cadastro_Moradores(lista_moradores);
        //    cad.ShowDialog();
        //}

        //private void btMoradoresCadastrados_Click(object sender, EventArgs e)
        //{
        //    if (lista_moradores.Count != 0)
        //    {
        //        MoradoresCadastrados mor = new MoradoresCadastrados(lista_moradores);
        //        mor.ShowDialog();
        //    }
        //    else
        //        MessageBox.Show("Nenhum morador cadastrado!", "Info");
   }               
}

