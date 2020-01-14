using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class MarcaDAO
    {
        private readonly MySqlConnection conexao;
        public MarcaDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        #region cadastra marca
        public void cadastra_marca(Marca m)
        {
            try
            {
                string sql = "sp_cadastra_marca('" + m.marca_nome + "');";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao cadastrar. (erro marcadao)");
            }

        }
        #endregion

        #region Exlui marca
        public void exclui_marca(Marca m)
        {
            try
            {
                string sql = "sp_deleta_marca(" + m.marca_id + ");";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao excluir. (erro marcadao)");
            }

        }
        #endregion

        #region Altera marca
        public void altera_marca(Marca m)
        {
            try
            {
                string sql = "call sp_altera_marca(" + m.marca_id + ",'" + m.marca_nome + "');";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao alterar. (erro marcadao)");
            }

        }
        #endregion

        #region mostra tabela marca
        public DataTable mostra_marca()
        {
            MySqlCommand cmd = new MySqlCommand("select tb_marca_id as 'ID', tb_marca_nome as 'Marca' from tb_marca", conexao);
            conexao.Open();
            cmd.ExecuteNonQuery();
            DataTable dt_marca = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt_marca);
            conexao.Close();
            return dt_marca;

        }
        #endregion
    }
}
