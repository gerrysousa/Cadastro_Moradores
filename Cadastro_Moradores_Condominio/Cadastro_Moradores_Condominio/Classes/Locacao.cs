using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Cadastro_Moradores_Condominio
{
    public class Locacao
    {
        #region Variaveis
        private string UnidadeAlocada;
        private string NomeProprietario;
        private string FoneProprietario;
        private string NomeImobiliaria;
        private string FoneImobiliaria;
        private int IdResponsavel;
        public static int IDTeste;
        #endregion

        #region Construtores
        public Locacao()
        { }

        public Locacao(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria)
        {
            this.UnidadeAlocada = pUnidadeAlocada;
            this.NomeProprietario = pNomeProprietario;
            this.FoneProprietario = pFoneProprietario;
            this.NomeImobiliaria = pNomeImobiliaria;
            this.FoneImobiliaria = pFoneImobiliaria;
        }

        #endregion

        #region GETs e SETs
        public string unidadeAlocada
        {
            get { return this.UnidadeAlocada; }
            set { this.UnidadeAlocada = value; }
        }

        public string nomeProprietario
        {
            get { return this.NomeProprietario; }
            set { this.NomeProprietario = value; }
        }

        public string foneProprietario
        {
            get { return this.FoneProprietario; }
            set { this.FoneProprietario = value; }
        }

        public string nomeImobiliaria
        {
            get { return this.NomeImobiliaria; }
            set { this.NomeImobiliaria = value; }
        }

        public string foneImobiliaria
        {
            get { return this.FoneImobiliaria; }
            set { this.FoneImobiliaria = value; }
        }

        public int IDResponsavel
        {
            get { return this.IdResponsavel; }
            set { this.IdResponsavel = value; }
        }
        #endregion

        #region Constantes para o CRUD do BD
        //Variaveis de conexao Add Referencia "System.Configurarion"
        public string strConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        // Variaveis contantes para SQL para o CRUd
        public const string strInsert = "INSERT INTO Locacao Values(@UnidadeAlocada, @NomeProprietario, @FoneProprietario, @NomeImobiliaria, @FoneImobiliaria, @IDResponsavel)";
        public const string strDelete = "DELETE FROM Locacao where ID= @ID";
        public const string strUpdate = "UPDATE Locacao SET  UnidadeAlocada=@UnidadeAlocada, NomeProprietario=@NomeProprietario, FoneProprietario=@FoneProprietario, NomeImobiliaria=@NomeImobiliaria, FoneImobiliaria=@FoneImobiliaria WHERE IDResponsavel=@IDResponsavel";
        public const string strSelect = "SELECT L.UnidadeAlocada, L.NomeProprietario, L.FoneProprietario, L.NomeImobiliaria, L.FoneImobiliaria FROM Locacao AS L INNER JOIN Morador AS m ON L.IdResponsavel = m.ID WHERE (L.IdResponsavel = @IdResponsavel)";
        #endregion

        #region Manipulaçao dos dados

        public void Salvar(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria, int pIdResponsavel)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@UnidadeAlocada", pUnidadeAlocada);
                    objComando.Parameters.AddWithValue("@NomeProprietario", pNomeProprietario);
                    objComando.Parameters.AddWithValue("@FoneProprietario", pFoneProprietario);
                    objComando.Parameters.AddWithValue("@NomeImobiliaria", pNomeImobiliaria);
                    objComando.Parameters.AddWithValue("@FoneImobiliaria", pFoneImobiliaria);
                    objComando.Parameters.AddWithValue("@IdResponsavel", pIdResponsavel);

                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Atualizar(string pUnidadeAlocada, string pNomeProprietario, string pFoneProprietario, string pNomeImobiliaria, string pFoneImobiliaria, int pIdResponsavel)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@UnidadeAlocada", pUnidadeAlocada);
                    objComando.Parameters.AddWithValue("@NomeProprietario", pNomeProprietario);
                    objComando.Parameters.AddWithValue("@FoneProprietario", pFoneProprietario);
                    objComando.Parameters.AddWithValue("@NomeImobiliaria", pNomeImobiliaria);
                    objComando.Parameters.AddWithValue("@FoneImobiliaria", pFoneImobiliaria);
                    objComando.Parameters.AddWithValue("@IdResponsavel", pIdResponsavel);

                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        /*public void Excluir(int Id)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@ID", Id);

                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }*/

        public Locacao SelecionarLocacao(int pIDResponsavel)
        {/*
            string UnidadeAlocada = String.Empty;
            string NomeProprietario = String.Empty;
            string FoneProprietario = String.Empty;
            string NomeImobiliaria = String.Empty;
            string FoneImobiliaria = String.Empty;
            string Observacaov = "";*/
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    try
                    {
                        objComando.Parameters.AddWithValue("@IdResponsavel", Convert.ToString(IDTeste));
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();
                        Locacao objLocacao = new Locacao();
                        if (objDataReader.HasRows)
                        {
                            objDataReader.Read();
                            
                            objLocacao.unidadeAlocada = objDataReader["UnidadeAlocada"].ToString();
                            objLocacao.nomeProprietario = objDataReader["NomeProprietario"].ToString();
                            objLocacao.foneProprietario = objDataReader["FoneProprietario"].ToString();
                            objLocacao.nomeImobiliaria = objDataReader["NomeImobiliaria"].ToString();
                            objLocacao.foneImobiliaria = objDataReader["FoneImobiliaria"].ToString();

                        }
                        objConexao.Close();

                        return objLocacao;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro!" + ex.Message);
                       // throw;
                    }
                }
            }
            Locacao objLocacaoFalha = new Locacao();
            return objLocacaoFalha;
        }

       /*
  public List<Locacao> Selecionar()
         {

             List<Locacao> lstLocacaos = new List<Locacao>();

             using (SqlConnection objConexao = new SqlConnection(strConexao))
             {
                 using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                 {
                     try
                     {
                         objComando.Parameters.AddWithValue("@IdResponsavel", Convert.ToString(IDTeste));
                         objConexao.Open();
                         SqlDataReader objDataReader = objComando.ExecuteReader();

                         if (objDataReader.HasRows)
                         {
                             while (objDataReader.Read())
                             {
                                 Locacao objLocacao = new Locacao();
                                 objLocacao.unidadeAlocada = objDataReader["UnidadeAlocada"].ToString();
                                 objLocacao.nomeProprietario = objDataReader["NomeProprietario"].ToString();
                                 objLocacao.foneProprietario = objDataReader["FoneProprietario"].ToString();
                                 objLocacao.nomeImobiliaria = objDataReader["NomeImobiliaria"].ToString();
                                 objLocacao.foneImobiliaria = objDataReader["FoneImobiliaria"].ToString();

                                 lstLocacaos.Add(objLocacao);
                             }
                             objDataReader.Close();
                         }
                         objConexao.Close();
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Erro!" + ex.Message);
                         //throw;
                     }
                 }
             }

             return lstLocacaos;
         }*/
        #endregion
    }
}


