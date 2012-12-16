using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Cadastro_Moradores_Condominio
{
    public class Observacao
    {
        private int IdResponsavel;
        private string Observacaov;
        public static int IDTeste;

        #region Construtores
        public Observacao()
        { }

        public Observacao(string pObservacao)
        {
            this.Observacaov = pObservacao;
        }

        #endregion

        #region GETs e SETs

        public string observacaov
        {
            get { return this.Observacaov; }
            set { this.Observacaov = value; }
        }

        public int IDResponsavel
        {
            get { return this.IdResponsavel; }
            set { this.IdResponsavel = value; }
        }
        #endregion

        #region Constantes para o CRUD
        //Variaveis de conexao Add Referencia "System.Configurarion"
        public string strConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        // Variaveis contantes para SQL para o CRUd
        public const string strInsert = "INSERT INTO Observacao Values(@IDResponsavel, @Observacao)";
        public const string strDelete = "DELETE FROM Observacao where ID= @ID";
        public const string strUpdate = "UPDATE Observacao SET  observacao=@observacao WHERE IDResponsavel=@IDResponsavel";//,,   ID=@Id";ID=@ID,
        public const string strSelect = "SELECT o.observacao FROM Observacao AS o INNER JOIN Morador AS m ON o.IdResponsavel = m.ID WHERE (o.IdResponsavel = @IdResponsavel)";
        #endregion

        #region Manipulaçao dos dados

        public void Salvar(int pIdResponsavel, string pObservacaov)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@IdResponsavel", pIdResponsavel);
                    objComando.Parameters.AddWithValue("@observacao", pObservacaov);

                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Atualizar(int pIdResponsavel, string pObservacaov)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@IdResponsavel", pIdResponsavel);
                    objComando.Parameters.AddWithValue("@observacao", pObservacaov);

                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Excluir(int Id)
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
        }

        public List<Observacao> Selecionar()
        {
            List<Observacao> lstObservacaos = new List<Observacao>();

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
                                Observacao objObservacao = new Observacao();
                                //objObservacao.IdResponsavel = Convert.ToInt32(objDataReader["IDResponsavel"].ToString());
                                objObservacao.Observacaov = objDataReader["Observacaov"].ToString();

                                lstObservacaos.Add(objObservacao);
                            }
                            objDataReader.Close();
                        }
                        objConexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro!" + ex.Message);
                        throw;
                    }
                }
            }

            return lstObservacaos;
        }

        public string BuscaObservacao(int pIDResponsavel)
        {
            string Observacaov = "";
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
                            objDataReader.Read();
                            //nome = leitor["Nome"].ToString();
                            Observacaov = objDataReader["Observacao"].ToString();
                        }
                        objConexao.Close();
                        //retorno o nome
                        return Observacaov;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro!" + ex.Message);
                        throw;
                    }
                }
            }
        }
        #endregion
    }
}

