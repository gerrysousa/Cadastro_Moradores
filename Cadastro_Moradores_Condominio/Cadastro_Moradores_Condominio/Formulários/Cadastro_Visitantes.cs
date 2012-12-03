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
    public partial class Cadastro_Visitantes : Form
    {
        string tipo;
        Visitante visitante;

        public Cadastro_Visitantes(Visitante visitante, string tipo)
        {
            this.tipo = tipo;
            this.visitante = visitante;
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            visitante.SetVisitante(0, tbVisitante1.Text);
            visitante.SetParentesco(0, tbParentesco1.Text);
            visitante.SetVisitante(1, tbVisitante2.Text);
            visitante.SetParentesco(1, tbParentesco2.Text);
            visitante.SetVisitante(2, tbVisitante3.Text);
            visitante.SetParentesco(2, tbParentesco3.Text);
            visitante.SetVisitante(3, tbVisitante4.Text);
            visitante.SetVisitante(3, tbParentesco4.Text);
            visitante.SetVisitante(4, tbVisitante5.Text);
            visitante.SetParentesco(4, tbParentesco5.Text);
            visitante.SetVisitante(5, tbVisitante6.Text);
            visitante.SetParentesco(5, tbParentesco6.Text);
            this.Close();
        }

        private void Cadastro_Visitantes_Load(object sender, EventArgs e)
        {
            if (tipo == "exibicao")
            {
                btSalvar.Enabled = false;
                btSalvar.Visible = false;
                tbVisitante1.Text = visitante.GetVisitante(0);
                tbParentesco1.Text = visitante.GetParentesco(0);
                tbVisitante2.Text = visitante.GetVisitante(1);
                tbParentesco2.Text = visitante.GetParentesco(1);
                tbVisitante3.Text = visitante.GetVisitante(2);
                tbParentesco3.Text = visitante.GetParentesco(2);
                tbVisitante4.Text = visitante.GetVisitante(3);
                tbParentesco4.Text = visitante.GetParentesco(3);
                tbVisitante5.Text = visitante.GetVisitante(4);
                tbParentesco5.Text = visitante.GetParentesco(4);
                tbVisitante6.Text = visitante.GetVisitante(5);
                tbParentesco6.Text = visitante.GetParentesco(5);
            }
        }
    }
}
