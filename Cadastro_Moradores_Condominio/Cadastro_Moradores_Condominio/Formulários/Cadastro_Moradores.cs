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
        private Dependente dependente;
        private Visitante visitante;
        private Observacao observacao;
        private Veiculo veiculo;
        private Locacao locacao;
        private Morador morador;
        private List<Morador> lista_moradores = new List<Morador>();

        public Cadastro_Moradores(List<Morador> lista_moradores)
        {
            this.lista_moradores = lista_moradores;
            InitializeComponent();
        }

        #region VerificaDDD
        protected string VerificaDDD(string parametro)
        {
            string result;
            switch (parametro)
            {
                case "11":
                    result = "São Paulo";
                    break;
                case "12":
                    result = "S. José dos Campos";
                    break;
                case "13":
                    result = "Santos";
                    break;
                case "14":
                    result = "Bauru";
                    break;
                case "15":
                    result = "Sorocaba";
                    break;
                case "16":
                    result = "Ribeirão Preto";
                    break;
                case "17":
                    result = "São José do Rio Preto";
                    break;
                case "18":
                    result = "Presidente Prudente";
                    break;
                case "19":
                    result = "Campinas";
                    break;
                case "21":
                    result = "Rio de Janeiro";
                    break;
                case "22":
                    result = "Campos";
                    break;
                case "24":
                    result = "Volta Redonda";
                    break;
                case "27":
                    result = "Vitória";
                    break;
                case "28":
                    result = "Cach. de Itapemirim";
                    break;
                case "31":
                    result = "Belo Horizonte";
                    break;
                case "32":
                    result = "Juiz de Fora";
                    break;
                case "33":
                    result = "Gov. Valadares";
                    break;
                case "34":
                    result = "Uberlândia";
                    break;
                case "35":
                    result = "Varginha";
                    break;
                case "37":
                    result = "Divinópolis";
                    break;
                case "38":
                    result = "Montes Claros";
                    break;
                case "41":
                    result = "Curitiba";
                    break;
                case "42":
                    result = "Ponta Grossa";
                    break;
                case "43":
                    result = "Londrina";
                    break;
                case "44":
                    result = "Maringá";
                    break;
                case "45":
                    result = "Foz do Iguaçú";
                    break;
                case "46":
                    result = "Pato Branco";
                    break;
                case "47":
                    result = "Joinville";
                    break;
                case "48":
                    result = "Florianópolis";
                    break;
                case "49":
                    result = "Chapecó";
                    break;
                case "51":
                    result = "Porto Alegre";
                    break;
                case "53":
                    result = "Pelotas";
                    break;
                case "54":
                    result = "Caxias do Sul";
                    break;
                case "55":
                    result = "Santa Maria";
                    break;
                case "61":
                    result = "Brasília";
                    break;
                case "62":
                    result = "Goiânia";
                    break;
                case "63":
                    result = "Palmas";
                    break;
                case "64":
                    result = "Rio Verde";
                    break;
                case "65":
                    result = "Cuiabá";
                    break;
                case "66":
                    result = "Rondonópolis";
                    break;
                case "67":
                    result = "Campo Grande";
                    break;
                case "68":
                    result = "Rio Branco";
                    break;
                case "69":
                    result = "Porto Velho";
                    break;
                case "71":
                    result = "Salvador";
                    break;
                case "73":
                    result = "Ilhéus";
                    break;
                case "74":
                    result = "Juazeiro";
                    break;
                case "75":
                    result = "Feira de Santana";
                    break;
                case "77":
                    result = "Barreiras";
                    break;
                case "79":
                    result = "Aracaju";
                    break;
                case "81":
                    result = "Recife";
                    break;
                case "82":
                    result = "Maceió";
                    break;
                case "83":
                    result = "João Pessoa";
                    break;
                case "84":
                    result = "Natal";
                    break;
                case "85":
                    result = "Fortaleza";
                    break;
                case "86":
                    result = "Teresina";
                    break;
                case "87":
                    result = "Petrolina";
                    break;
                case "88":
                    result = "Juazeiro do Norte";
                    break;
                case "89":
                    result = "Picos";
                    break;
                case "91":
                    result = "Belém";
                    break;
                case "92":
                    result = "Manaus";
                    break;
                case "93":
                    result = "Santarém";
                    break;
                case "94":
                    result = "Marabá";
                    break;
                case "95":
                    result = "Boa Vista";
                    break;
                case "96":
                    result = "Macapá";
                    break;
                case "97":
                    result = "Coari";
                    break;
                case "98":
                    result = "São Luis";
                    break;
                case "99":
                    result = "São Luis";
                    break;
                default: result = "";
                    break;
            }
            return result;
        }
        #endregion

        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            ttpDDD.Show(VerificaDDD(cbDddResidencial.Text), cbDddResidencial);
        }

        private void comboBox6_MouseHover(object sender, EventArgs e)
        {
            ttpDDD.Show(VerificaDDD(cbDddCelular1.Text), cbDddCelular1);
        }

        private void comboBox4_MouseHover(object sender, EventArgs e)
        {
            ttpDDD.Show(VerificaDDD(cbDddComercial.Text), cbDddComercial);
        }

        private void comboBox5_MouseHover(object sender, EventArgs e)
        {
            ttpDDD.Show(VerificaDDD(cbDddCelular2.Text), cbDddCelular2);
        }

        private void comboBox3_MouseLeave(object sender, EventArgs e)
        {
            ttpDDD.Hide(cbDddResidencial);
        }

        private void comboBox6_MouseLeave(object sender, EventArgs e)
        {
            ttpDDD.Hide(cbDddCelular1);
        }

        private void comboBox4_MouseLeave(object sender, EventArgs e)
        {
            ttpDDD.Hide(cbDddComercial);
        }

        private void comboBox5_MouseLeave(object sender, EventArgs e)
        {
            ttpDDD.Hide(cbDddCelular2);
        }

        private void btCadastroDependentes_Click(object sender, EventArgs e)
        {
            dependente = new Dependente();
            Cadastro_Depententes dep = new Cadastro_Depententes(dependente,"cadastro");
            dep.ShowDialog();
        }

        private void btCadastroVisitantes_Click(object sender, EventArgs e)
        {
            visitante = new Visitante();
            Cadastro_Visitantes vis = new Cadastro_Visitantes(visitante, "cadastro");
            vis.ShowDialog();
        }

        private void btCadastroVeiculos_Click(object sender, EventArgs e)
        {
            veiculo = new Veiculo();
            CadastroVeiculos veic = new CadastroVeiculos(veiculo, "cadastro");
            veic.ShowDialog();
        }

        private void btCadastroLocacao_Click(object sender, EventArgs e)
        {
            locacao = new Locacao();
            CadastroLocacao loc = new CadastroLocacao(locacao, "cadastro");
            loc.ShowDialog();
        }

        private void btCadastroObservacoes_Click(object sender, EventArgs e)
        {
            observacao = new Observacao();
            CadastroObservacoes obs = new CadastroObservacoes(observacao,"cadastro");
            obs.ShowDialog();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbMorador.Text == "")
            {
                MessageBox.Show("Campo Morador deve ser obrigatoriamente preenchido", "Info");
            }
            else
            {
                int id = lista_moradores.Count;
                try
                {

                    morador = new Morador();
                    morador.ID = id;
                    if (tbMorador.Text != "")
                        morador.Apartamento = mbApartamento.Text;
                    morador.Bloco = cbBloco.Text;
                    morador.Celular1 = mbCelular1.Text;
                    morador.Celular2 = mbCelular2.Text;
                    morador.Cpf = mbCpf.Text;
                    if (mbCelular1.Text != "")
                        morador.DddCelular1 = cbDddCelular1.Text;
                    if (mbCelular2.Text != "")
                        morador.DddCelular2 = cbDddCelular2.Text;
                    if (mbTelefoneComercial.Text != "")
                        morador.DddComercial = cbDddComercial.Text;
                    if (mbTelefoneResidencial.Text != "")
                        morador.DddResidencial = cbDddResidencial.Text;
                    morador.Email = tbEmail.Text;
                    morador.Nome = tbMorador.Text;
                    morador.Predio = cbPredio.Text;
                    morador.Rg = tbIdentidade.Text;
                    morador.TelefoneComercial = mbTelefoneComercial.Text;
                    morador.TelefoneResidencial = mbTelefoneResidencial.Text;
                    morador.Dependente = dependente;
                    morador.Locacao = locacao;
                    morador.Observacao = observacao;
                    morador.Veiculo = veiculo;
                    morador.Visitante = visitante;
                    lista_moradores.Add(morador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
                this.Close();
            }
        }
    }
}
