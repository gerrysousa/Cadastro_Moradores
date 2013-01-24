using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cadastro_Moradores_Condominio
{
    public class Morador
    {
        #region Variaveis
        private int ID;
        private string Nome;
        private string Predio;
        private string Bloco;
        private string Email;
        private string Rg;
        private string TelefoneResidencial;
        private string TelefoneComercial;
        private string Celular1;
        private string Celular2;
        private string Cpf;
        private string Apartamento;
        private int IDRespn;
        #endregion

        #region Constantes para o CRUD
        //Variaveis de conexao Add Referencia "System.Configurarion"
        public string strConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        // Variaveis contantes para SQL para o CRUd
        public const string strInsert = "INSERT INTO Morador Values(@ID, @nome, @Predio, @Bloco, @Email,@Rg, @TelefoneResidencial, @TelefoneComercial, @Celular1, @Celular2, @Apartamento, @IDResponsavel, @Cpf )";
        public const string strDelete = "DELETE FROM Morador where ID= @ID";
        public const string strUpdate = "UPDATE Morador SET ID=@ID, Nome=@nome, Predio=@Predio, Bloco=@Bloco, Email=@Email, Rg=@Rg, TelefoneResidencial=@TelefoneResidencial, TelefoneComercial=@TelefoneComercial, Celular1=@Celular1, Celular2=@Celular2, Apartamento=@Apartamento, Cpf=@Cpf, IDResponsavel=@IDResponsavel where ID=@ID";
        public const string strSelectAll = "SELECT * FROM Morador";
        public const string strSelectLogin = "SELECT IdLogin,Login,Senha FROM Login WHERE Login = @Login AND Senha=@Senha";
        public const string strSelectByName = "SELECT * FROM Morador WHERE (nome LIKE @nome)";
        #endregion

        #region Construtores
        public Morador()
        { }

        public Morador(int pID, string pNome, string pPredio, string pBloco, string pEmail, string pRg, string pTelefoneResidencial, string pTelefoneComercial, string pCelular1, string pCelular2, string pCpf, string pApartamento, int pIDRespn)
        {
            this.ID = pID;
            this.Nome = pNome;
            this.Apartamento = pApartamento;
            this.Bloco = pBloco;
            this.Celular1 = pCelular1;
            this.Celular2 = pCelular2;
            this.Cpf = pCpf;
            this.Email = pEmail;
            this.TelefoneComercial = pTelefoneComercial;
            this.TelefoneResidencial = pTelefoneResidencial;
            this.IDRespn = pIDRespn;
            this.Predio = pPredio;
            this.Rg = pRg;
        }

        #endregion

        #region GETs e SETs
        public int Id
        {
            get { return this.ID; }
            set { this.ID = value; }
        }
        public string predio
        {
            get { return this.Predio; }
            set { this.Predio = value; }
        }

        public string nome
        {
            get { return this.Nome; }
            set { this.Nome = value; }
        }
        public string bloco
        {
            get { return this.Bloco; }
            set { this.Bloco = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public string RG
        {
            get { return this.Rg; }
            set { this.Rg = value; }
        }
        public string telefoneResidencial
        {
            get { return this.TelefoneResidencial; }
            set { this.TelefoneResidencial = value; }
        }
        public string telefoneComercial
        {
            get { return this.TelefoneComercial; }
            set { this.TelefoneComercial = value; }
        }
        public string celular1
        {
            get { return this.Celular1; }
            set { this.Celular1 = value; }
        }
        public string celular2
        {
            get { return this.Celular2; }
            set { this.Celular2 = value; }
        }
        public string CPF
        {
            get { return this.Cpf; }
            set { this.Cpf = value; }
        }
        public string apartamento
        {
            get { return this.Apartamento; }
            set { this.Apartamento = value; }
        }
        public int IdRespn
        {
            get { return this.IDRespn; }
            set { this.IDRespn = value; }
        }

        #endregion

        #region Manipulaçao dos dados

        public void Salvar(int pID, string pNome, string pPredio, string pBloco, string pEmail, string pRg, string pTelefoneResidencial, string pTelefoneComercial, string pCelular1, string pCelular2, string pCpf, string pApartamento, int pIDRespn)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    try
                    {
                        objComando.Parameters.AddWithValue("@ID", pID);
                        objComando.Parameters.AddWithValue("@nome", pNome);
                        objComando.Parameters.AddWithValue("@Predio", pPredio);
                        objComando.Parameters.AddWithValue("@bloco", pBloco);
                        objComando.Parameters.AddWithValue("@email", pEmail);
                        objComando.Parameters.AddWithValue("@rg", pRg);
                        objComando.Parameters.AddWithValue("@telefoneResidencial", pTelefoneResidencial);
                        objComando.Parameters.AddWithValue("@telefoneComercial", pTelefoneComercial);
                        objComando.Parameters.AddWithValue("@celular1", pCelular1);
                        objComando.Parameters.AddWithValue("@celular2", pCelular2);
                        objComando.Parameters.AddWithValue("@Cpf", pCpf);
                        objComando.Parameters.AddWithValue("@Apartamento", pApartamento);
                        objComando.Parameters.AddWithValue("@IDResponsavel", pIDRespn);

                        objConexao.Open();
                        objComando.ExecuteNonQuery();
                        objConexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro! "+ex);
                       // throw;
                    }
                    
                }
            }
        }

        public void Atualizar(int pID, string pNome, string pPredio, string pBloco, string pEmail, string pRg, string pTelefoneResidencial, string pTelefoneComercial, string pCelular1, string pCelular2, string pCpf, string pApartamento, int pIDRespn)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    try
                    {
                        objComando.Parameters.AddWithValue("@ID", pID);
                        objComando.Parameters.AddWithValue("@nome", pNome);
                        objComando.Parameters.AddWithValue("@Predio", pPredio);
                        objComando.Parameters.AddWithValue("@Bloco", pBloco);
                        objComando.Parameters.AddWithValue("@Email", pEmail);
                        objComando.Parameters.AddWithValue("@Rg", pRg);
                        objComando.Parameters.AddWithValue("@TelefoneResidencial", pTelefoneResidencial);
                        objComando.Parameters.AddWithValue("@TelefoneComercial", pTelefoneComercial);
                        objComando.Parameters.AddWithValue("@Celular1", pCelular1);
                        objComando.Parameters.AddWithValue("@Celular2", pCelular2);
                        objComando.Parameters.AddWithValue("@Cpf", pCpf);
                        objComando.Parameters.AddWithValue("@Apartamento", pApartamento);
                        objComando.Parameters.AddWithValue("@IDResponsavel", pIDRespn);

                        objConexao.Open();
                        objComando.ExecuteNonQuery();
                        objConexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro!" + ex.Message);
                        //throw;
                    }
                   
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

        public List<Morador> SelecionarTodos()
        {
            List<Morador> lstMoradores = new List<Morador>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelectAll, objConexao))
                {
                    try
                    {
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();

                        if (objDataReader.HasRows)
                        {
                            while (objDataReader.Read())
                            {
                                Morador objMorador = new Morador();
                                objMorador.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objMorador.Nome = objDataReader["nome"].ToString();
                                objMorador.Apartamento = objDataReader["Apartamento"].ToString();
                                objMorador.Bloco = objDataReader["bloco"].ToString();
                                objMorador.Celular1 = objDataReader["Celular1"].ToString();
                                objMorador.Celular2 = objDataReader["Celular2"].ToString();
                                objMorador.Cpf = objDataReader["Cpf"].ToString();
                                objMorador.Email = objDataReader["Email"].ToString();
                                objMorador.IDRespn = Convert.ToInt32(objDataReader["IDResponsavel"].ToString());
                                objMorador.Predio = objDataReader["Predio"].ToString();
                                objMorador.Rg = objDataReader["Rg"].ToString();
                                objMorador.TelefoneComercial = objDataReader["TelefoneComercial"].ToString();
                                objMorador.TelefoneResidencial = objDataReader["TelefoneResidencial"].ToString();

                                lstMoradores.Add(objMorador);
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

            return lstMoradores;
        }

        public List<Morador> SelecionarPorNome(string pNome)
        {
            List<Morador> lstMoradores = new List<Morador>();

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
                                Morador objMorador = new Morador();
                                objMorador.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objMorador.Nome = objDataReader["nome"].ToString();
                                objMorador.Apartamento = objDataReader["Apartamento"].ToString();
                                objMorador.Bloco = objDataReader["bloco"].ToString();
                                objMorador.Celular1 = objDataReader["Celular1"].ToString();
                                objMorador.Celular2 = objDataReader["Celular2"].ToString();
                                objMorador.Cpf = objDataReader["Cpf"].ToString();
                                objMorador.Email = objDataReader["Email"].ToString();
                                objMorador.IDRespn = Convert.ToInt32(objDataReader["IDResponsavel"].ToString());
                                objMorador.Predio = objDataReader["Predio"].ToString();
                                objMorador.Rg = objDataReader["Rg"].ToString();
                                objMorador.TelefoneComercial = objDataReader["TelefoneComercial"].ToString();
                                objMorador.TelefoneResidencial = objDataReader["TelefoneResidencial"].ToString();

                                lstMoradores.Add(objMorador);
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

            return lstMoradores;
        }
        #endregion
    }
}