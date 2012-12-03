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
    public partial class Depententes : Form
    {
        List<Dependentes> dependentes = new List<Dependentes>();
        Dependentes dependente = new Dependentes();
        public Depententes(List<Dependentes> dependentes)
        {
            InitializeComponent();
            this.dependentes = dependentes;
        }

        private void button1_Click(object sender, EventArgs e)
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
            dependentes.Add(dependente);
        }

        private void Depententes_Load(object sender, EventArgs e)
        {
            if (dependentes.Count != 0)
            {
                tbDependentes1.Text = dependentes[0].GetDependente(0);
                tbParentesco1.Text = dependentes[0].GetParentesco(0);
                tbDependentes2.Text = dependentes[0].GetDependente(1);
                tbParentesco2.Text = dependentes[0].GetParentesco(1);
                tbDependentes3.Text = dependentes[0].GetDependente(2);
                tbParentesco3.Text = dependentes[0].GetParentesco(2);
                tbDependentes4.Text = dependentes[0].GetDependente(3);
                tbParentesco4.Text = dependentes[0].GetParentesco(3);
                tbDependentes5.Text = dependentes[0].GetDependente(4);
                tbParentesco5.Text = dependentes[0].GetParentesco(4);
                tbDependentes6.Text = dependentes[0].GetDependente(4);
                tbParentesco6.Text = dependentes[0].GetParentesco(4);
            }
        }              
    }
}
