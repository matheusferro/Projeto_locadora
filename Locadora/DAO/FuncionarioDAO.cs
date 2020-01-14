using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class FuncionarioDAO
    {
        private readonly MySqlConnection conexao;
        public FuncionarioDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }
        public DataTable lista_funcionario()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_mostra_funcionario", conexao)
                {
                    CommandType = CommandType.StoredProcedure
                };
                conexao.Open();
                cmd.ExecuteNonQuery();
                DataTable dt_funcionario = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt_funcionario);
                conexao.Close();
                return dt_funcionario;

            }
            catch (Exception t)
            {
                MessageBox.Show("erro funcionariodao" + t);
                return null;
            }
        }

        #region cadastro
        public void cadastra_funcionario(Funcionario f)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_cadastra_funcionario", conexao);
                cmd.Parameters.AddWithValue("@nome", f.funcionarionome);
                cmd.Parameters.AddWithValue("@tel", f.funcionariotel);
                cmd.Parameters.AddWithValue("@dt_contrato", f.dt_contrato);
                cmd.Parameters.AddWithValue("@cargo", f.id_cargo);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro funcionariodao" + e);
            }

        }
        #endregion

        #region busca
        public DataTable busca(Funcionario f)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_busca_funcionario", conexao);
                cmd.Parameters.AddWithValue("nome", f.funcionarionome);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                conexao.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Alterar
        public void altera_funcionario_pqp(Funcionario f)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_altera_funcionario", conexao);
                cmd.Parameters.AddWithValue("@funcionario_id", f.funcionarioid);
                cmd.Parameters.AddWithValue("@nome", f.funcionarionome);
                cmd.Parameters.AddWithValue("@tel", f.funcionariotel);
                cmd.Parameters.AddWithValue("@dt_contrato", f.dt_contrato);
                cmd.Parameters.AddWithValue("@cargo", f.id_cargo);
                cmd.CommandType = CommandType.StoredProcedure;


                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro funcionariodao" + e);
            }

        }
        #endregion

        #region Exclusao

        public void exclui_funcionario_pqp(Funcionario f)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleta_funcionario", conexao);
                cmd.Parameters.AddWithValue("@funcionario_id", f.funcionarioid);

                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro funcionariodao" + e);
            }

        }
        #endregion

    }
}
