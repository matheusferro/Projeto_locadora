using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class ModeloDAO
    {
        private readonly MySqlConnection conexao;
        public ModeloDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        public void cadastra_modelo(Modelo m)
        {
            try
            {
                string sql = @"call sp_cadastra_modelo('" + m.modelo_desc + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no modelodao(cadastra)");
            }
        }

        public void altera_modelo(Modelo m)
        {
            try
            {
                string sql = "call sp_altera_modelo(" + m.modelo_id + ",'" + m.modelo_desc + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erro modelodao(altera).");
            }
        }

        public void deleta_modelo(Modelo m)
        {
            try
            {
                string sql = "call sp_deleta_modelo(" + m.modelo_id + ");";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("erro modelodao(excluir).");
            }
        }



        public DataTable lista_modelo()
        {
            string sql = "select tb_modelo_id as 'ID', tb_modelo_desc as 'Modelo' from tb_modelo;";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            conexao.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexao.Close();

            return dt;
        }

    }
}
