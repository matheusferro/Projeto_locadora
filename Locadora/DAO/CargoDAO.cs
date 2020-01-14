using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class CargoDAO
    {
        private readonly MySqlConnection conexao;
        public CargoDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        #region cadastra cargo
        public void cadastra_cargo(Cargo c)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("sp_cadastra_cargo", conexao);
                cmd.Parameters.AddWithValue("nome_cargo", c.cargo_nome);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cargo cadastrado com sucesso !");
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro cargodao(cadastrar)");
            }

        }
        #endregion

        public void altera_cargo(Cargo c)
        {
            try
            {
                string sql = "call sp_altera_cargo(" + c.cargoid + ",'" + c.cargo_nome + "');";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception y)
            {
                MessageBox.Show("Erro cargodao(alterar)" + y);
            }

        }
        public void exclui_cargo(Cargo c)
        {
            try
            {
                string sql = "call sp_deleta_cargo(" + c.cargoid + ");";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro cargodao(excluir)");
            }

        }

        public DataTable lista_cargo()
        {
            try
            {
                string sql = "select * from tb_cargo;";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro cargodao(listar)" + e);
                return null;
            }

        }

    }
}
