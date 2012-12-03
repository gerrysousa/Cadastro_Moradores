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
    public partial class Cadastro_Moradores : Form
    {
        public Cadastro_Moradores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Observacoes obs = new Observacoes();
            obs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Depententes dep = new Depententes();
            dep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visitantes vis = new Visitantes();
            vis.ShowDialog();
        }        
    }
}
