using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Cadastro_Moradores_Condominio
{
    public class Dependente
    {
        private int ID;
        private string Nome;
        private string Parentesco;
        private string Telefone;
        private int IdResponsavel;
        public static int IDTeste;

        #region Construtores
        public Dependente()
        { }

        public Dependente(int pID, string pNome, string pParentesco, string pTelefone)
        {
            this.ID = pID;
            this.Nome = pNome;
            this.Parentesco = pParentesco;
            this.Telefone = pTelefone;
        }

        #endregion

        #region GETs e SETs
        public int Id
        {
            get { return this.ID; }
            set { this.ID = value; }
        }
       
        public string nome
        {
            get { return this.Nome; }
            set { this.Nome = value; }
        }

        public string parentesco
        {
            get { return this.Parentesco; }
            set { this.Parentesco = value; }
        }

        public string telefone
        {
            get { return this.Telefone; }
            set { this.Telefone = value; }
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
        public const string strInsert = "INSERT INTO Dependente Values(@ID, @nome, @Parentesco, @Telefone, @IDResponsavel)";
        public const string strDelete = "DELETE FROM Dependente where ID= @ID";
        public const string strUpdate = "UPDATE Dependente SET Nome=@nome, Parentesco=@Parentesco, Telefone=@Telefone, IDResponsavel=@IDResponsavel WHERE ID=@Id";//ID=@ID,
        public const string strSelect = "SELECT d.ID, d.nome, d.parentesco, d.telefone, d.IdResponsavel FROM Dependente AS d INNER JOIN Morador AS m ON d.IdResponsavel = m.ID WHERE (d.IdResponsavel = @IdResponsavel)";
        public const string strSelectAll = "SELECT d.ID, d.nome, d.parentesco, d.telefone, d.IdResponsavel FROM Dependente AS d";
        public const string strSelectByName = "SELECT d.ID, d.nome, d.parentesco, d.telefone, d.IdResponsavel FROM Dependente AS d WHERE (nome LIKE @nome)";
        #endregion

        #region Manipulaçao dos dados

        public void Salvar(int pID, string pNome, string pParentesco, string pTelefone, int pIdResponsavel)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@ID", pID);
                    objComando.Parameters.AddWithValue("@nome", pNome);
                    objComando.Parameters.AddWithValue("@Parentesco", pParentesco);
                    objComando.Parameters.AddWithValue("@Telefone", pTelefone);
                    objComando.Parameters.AddWithValue("@IdResponsavel", pIdResponsavel);
                    
                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Atualizar(int pID, string pNome, string pParentesco, string pTelefone, int pIdResponsavel)
        {//int pID,
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@ID", pID);
                    objComando.Parameters.AddWithValue("@nome", pNome);
                    objComando.Parameters.AddWithValue("@Parentesco", pParentesco);
                    objComando.Parameters.AddWithValue("@Telefone", pTelefone);
                    objComando.Parameters.AddWithValue("@IdResponsavel", pIdResponsavel);

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

        public List<Dependente> Selecionar()
        {          
            List<Dependente> lstDependentes = new List<Dependente>();

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
                                Dependente objDependente = new Dependente();
                                objDependente.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objDependente.Nome = objDataReader["nome"].ToString();
                                objDependente.Parentesco = objDataReader["Parentesco"].ToString();
                                objDependente.Telefone = objDataReader["Telefone"].ToString();
                                objDependente.IdResponsavel = Convert.ToInt32(objDataReader["IdResponsavel"].ToString());

                                lstDependentes.Add(objDependente);
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

            return lstDependentes;
        }

        public List<Dependente> SelecionarTodos()
        {
            List<Dependente> lstDependentes = new List<Dependente>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelectAll, objConexao))
                {
                    try
                    {
                       // objComando.Parameters.AddWithValue("@IdResponsavel", Convert.ToString(IDTeste));
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();

                        if (objDataReader.HasRows)
                        {
                            while (objDataReader.Read())
                            {
                                Dependente objDependente = new Dependente();
                                objDependente.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objDependente.Nome = objDataReader["nome"].ToString();
                                objDependente.Parentesco = objDataReader["Parentesco"].ToString();
                                objDependente.Telefone = objDataReader["Telefone"].ToString();
                                objDependente.IdResponsavel = Convert.ToInt32(objDataReader["IdResponsavel"].ToString());

                                lstDependentes.Add(objDependente);
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

            return lstDependentes;
        }

        public List<Dependente> SelecionarPorNome(string pNome)
        {
            List<Dependente> lstDependentes = new List<Dependente>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelectByName, objConexao))
                {
                    try
                    {
                        objComando.Parameters.AddWithValue("@Nome", "%" + pNome + "%");
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();

                        if (objDataReader.HasRows)
                        {
                            while (objDataReader.Read())
                            {
                                Dependente objDependente = new Dependente();
                                objDependente.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objDependente.Nome = objDataReader["nome"].ToString();
                                objDependente.Parentesco = objDataReader["Parentesco"].ToString();
                                objDependente.Telefone = objDataReader["Telefone"].ToString();
                                objDependente.IdResponsavel = Convert.ToInt32(objDataReader["IdResponsavel"].ToString());

                                lstDependentes.Add(objDependente);
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

            return lstDependentes;
        }
        #endregion
    }
}
