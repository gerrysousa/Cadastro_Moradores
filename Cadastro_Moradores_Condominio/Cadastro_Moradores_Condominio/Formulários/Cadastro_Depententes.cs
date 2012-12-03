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
    public partial class Cadastro_Depententes : Form
    {
        string tipo;
        Dependente dependente;

        public Cadastro_Depententes(Dependente dependente, string tipo)
        {
            this.tipo = tipo;
            this.dependente = dependente;
            InitializeComponent();            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dependente.SetDependente(0, tbDependentes1.Text);
            dependente.SetParentesco(0, tbParentesco1.Text);
            dependente.SetDependente(1, tbDependentes2.Text);
            dependente.SetParentesco(1, tbParentesco2.Text);
            dependente.SetDependente(2, tbDependentes3.Text);
            dependente.SetParentesco(2, tbParentesco3.Text);
            dependente.SetDependente(3, tbDependentes4.Text);
            dependente.SetParentesco(3, tbParentesco4.Text);
            dependente.SetDependente(4, tbDependentes5.Text);
            dependente.SetParentesco(4, tbParentesco5.Text);
            dependente.SetDependente(5, tbDependentes6.Text);
            dependente.SetParentesco(5, tbParentesco6.Text);
            this.Close();
        }

        private void Cadastro_Depententes_Load(object sender, EventArgs e)
        {            
            if (tipo == "exibicao")
            {
                btSalvar.Enabled = false;
                btSalvar.Visible = false;
                tbDependentes1.Text = dependente.GetDependente(0);
                tbParentesco1.Text = dependente.GetParentesco(0);
                tbDependentes2.Text = dependente.GetDependente(1);
                tbParentesco2.Text = dependente.GetParentesco(1);
                tbDependentes3.Text = dependente.GetDependente(2);
                tbParentesco3.Text = dependente.GetParentesco(2);
                tbDependentes4.Text = dependente.GetDependente(3);
                tbParentesco4.Text = dependente.GetParentesco(3);
                tbDependentes5.Text = dependente.GetDependente(4);
                tbParentesco5.Text = dependente.GetParentesco(4);
                tbDependentes6.Text = dependente.GetDependente(5);
                tbParentesco6.Text = dependente.GetParentesco(5);
            }
        }             
    }
}
