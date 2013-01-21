using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Cadastro_Moradores_Condominio
{
    public class Veiculo
    {
        private int ID;
        private string Veiculov;
        private string Marca;
        private string Modelo;
        private string Cor;
        private string Placa;
        private string Ano;
        private int IdProprietario;
        public static int IDTeste;

        #region Construtores
        public Veiculo()
        { }

        public Veiculo(int pID, string pVeiculo, string pMarca, string pModelo, string pCor, string pPlaca, string pAno, int pIdProprietario)
        {
            this.ID = pID;
            this.Veiculov = pVeiculo;
            this.Modelo = pMarca;
            this.Modelo = pModelo;
            this.Cor = pCor;
            this.Placa = pPlaca;
            this.Ano = pAno;
            this.IdProprietario = pIdProprietario;
        }

        #endregion

        #region GETs e SETs
        public int Id
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public string veiculo
        {
            get { return this.Veiculov; }
            set { this.Veiculov = value; }
        }

        public string marca
        {
            get { return this.Marca; }
            set { this.Marca = value; }
        }

        public string modelo
        {
            get { return this.Modelo; }
            set { this.Modelo = value; }
        }
        public string cor
        {
            get { return this.Cor; }
            set { this.Cor = value; }
        }
        public string placa
        {
            get { return this.Placa; }
            set { this.Placa = value; }
        }
        public string ano
        {
            get { return this.Ano; }
            set { this.Ano = value; }
        }

        public int IDProprietario
        {
            get { return this.IdProprietario; }
            set { this.IdProprietario = value; }
        }
        #endregion

        #region Constantes para o CRUD
        //Variaveis de conexao Add Referencia "System.Configurarion"
        public string strConexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        // Variaveis contantes para SQL para o CRUd
        public const string strInsert = "INSERT INTO Veiculo Values(@ID, @Veiculo, @Marca, @Modelo, @Cor, @Placa, @Ano, @IDProprietario)";
        public const string strDelete = "DELETE FROM Veiculo where ID= @ID";
        public const string strUpdate = "UPDATE Veiculo SET Veiculo=@Veiculo, Marca=@Marca, Modelo=@Modelo, Cor=@Cor, Placa=@Placa, Ano=@Ano,IDProprietario=@IDProprietario WHERE ID=@Id";//ID=@ID,
        public const string strSelect = "SELECT v.ID, v.Veiculo, v.Marca, v.Modelo, v.Cor, v.Placa, v.Ano, v.IdProprietario FROM Veiculo AS v INNER JOIN Morador AS m ON v.IdProprietario = m.ID WHERE (v.IdProprietario = @IdProprietario)";
        public const string strSelectAll = "SELECT v.ID, v.Veiculo, v.Marca, v.Modelo, v.Cor, v.Placa, v.Ano, v.IdProprietario FROM Veiculo AS v";
        public const string strSelectByPlaca = "SELECT ID, Veiculo, Marca, Modelo, Cor, Placa, Ano, IdProprietario FROM Veiculo WHERE (Placa LIKE @Placa)";
        #endregion

        #region Manipulaçao dos dados

        public void Salvar(int pID, string pVeiculo, string pMarca, string pModelo, string pCor, string pPlaca, string pAno, int pIdProprietario)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@ID", pID);
                    objComando.Parameters.AddWithValue("@Veiculo", pVeiculo);
                    objComando.Parameters.AddWithValue("@Marca", pMarca);
                    objComando.Parameters.AddWithValue("@Modelo", pModelo);
                    objComando.Parameters.AddWithValue("@Cor", pCor);
                    objComando.Parameters.AddWithValue("@Placa", pPlaca);
                    objComando.Parameters.AddWithValue("@Ano", pAno);
                    objComando.Parameters.AddWithValue("@IdProprietario", pIdProprietario);

                    objConexao.Open();
                    objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }

        public void Atualizar(int pID, string pVeiculo, string pMarca, string pModelo, string pCor, string pPlaca, string pAno, int pIdProprietario)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@ID", pID);
                    objComando.Parameters.AddWithValue("@Veiculo", pVeiculo);
                    objComando.Parameters.AddWithValue("@Marca", pMarca);
                    objComando.Parameters.AddWithValue("@Modelo", pModelo);
                    objComando.Parameters.AddWithValue("@Cor", pCor);
                    objComando.Parameters.AddWithValue("@Placa", pPlaca);
                    objComando.Parameters.AddWithValue("@Ano", pAno);
                    objComando.Parameters.AddWithValue("@IdProprietario", pIdProprietario);

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
        

        public List<Veiculo> Selecionar()
        {
            List<Veiculo> lstVeiculos = new List<Veiculo>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    try
                    {
                        objComando.Parameters.AddWithValue("@IdProprietario", Convert.ToString(IDTeste));
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();

                        if (objDataReader.HasRows)
                        {//(pID, pVeiculo, pMarca, pModelo, Cor, pPlaca, pAno, pIdProprietario)
                            while (objDataReader.Read())
                            {
                                Veiculo objVeiculo = new Veiculo();
                                objVeiculo.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objVeiculo.Veiculov = objDataReader["Veiculo"].ToString();
                                objVeiculo.Marca = objDataReader["Marca"].ToString();
                                objVeiculo.Modelo = objDataReader["Modelo"].ToString();
                                objVeiculo.Cor = objDataReader["Cor"].ToString();
                                objVeiculo.Placa = objDataReader["Placa"].ToString();
                                objVeiculo.Ano = objDataReader["Ano"].ToString();
                                objVeiculo.IdProprietario = Convert.ToInt32(objDataReader["IdProprietario"].ToString());

                                lstVeiculos.Add(objVeiculo);
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

            return lstVeiculos;
        }

        public List<Veiculo> SelecionarTodos()
        {

            List<Veiculo> lstVeiculos = new List<Veiculo>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelectAll, objConexao))
                {
                    try
                    {
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();

                        if (objDataReader.HasRows)
                        {//(pID, pVeiculo, pMarca, pModelo, Cor, pPlaca, pAno, pIdProprietario)
                            while (objDataReader.Read())
                            {
                                Veiculo objVeiculo = new Veiculo();
                                objVeiculo.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objVeiculo.Veiculov = objDataReader["Veiculo"].ToString();
                                objVeiculo.Marca = objDataReader["Marca"].ToString();
                                objVeiculo.Modelo = objDataReader["Modelo"].ToString();
                                objVeiculo.Cor = objDataReader["Cor"].ToString();
                                objVeiculo.Placa = objDataReader["Placa"].ToString();
                                objVeiculo.Ano = objDataReader["Ano"].ToString();
                                objVeiculo.IdProprietario = Convert.ToInt32(objDataReader["IdProprietario"].ToString());

                                lstVeiculos.Add(objVeiculo);
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

            return lstVeiculos;
        }

        public List<Veiculo> SelecionarPorPlaca(string pPlaca)
        {
            List<Veiculo> lstVeiculos = new List<Veiculo>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strSelectByPlaca, objConexao))
                {
                    try
                    {
                        objComando.Parameters.AddWithValue("@Placa", "%" + pPlaca + "%");
                        objConexao.Open();
                        SqlDataReader objDataReader = objComando.ExecuteReader();

                        if (objDataReader.HasRows)
                        {//(pID, pVeiculo, pMarca, pModelo, Cor, pPlaca, pAno, pIdProprietario)
                            while (objDataReader.Read())
                            {
                                Veiculo objVeiculo = new Veiculo();
                                objVeiculo.ID = Convert.ToInt32(objDataReader["ID"].ToString());
                                objVeiculo.Veiculov = objDataReader["Veiculo"].ToString();
                                objVeiculo.Marca = objDataReader["Marca"].ToString();
                                objVeiculo.Modelo = objDataReader["Modelo"].ToString();
                                objVeiculo.Cor = objDataReader["Cor"].ToString();
                                objVeiculo.Placa = objDataReader["Placa"].ToString();
                                objVeiculo.Ano = objDataReader["Ano"].ToString();
                                objVeiculo.IdProprietario = Convert.ToInt32(objDataReader["IdProprietario"].ToString());

                                lstVeiculos.Add(objVeiculo);
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

            return lstVeiculos;
        }
        #endregion
    }
}
