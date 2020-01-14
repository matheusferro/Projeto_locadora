using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class AutomovelDAO
    {
        private readonly MySqlConnection conexao;

        public AutomovelDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        #region mostra veiculo
        public DataTable lista_auto()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_mostra_auto", conexao)
                {
                    CommandType = CommandType.StoredProcedure
                };
                conexao.Open();
                cmd.ExecuteNonQuery();

                DataTable dtauto = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dtauto);

                conexao.Close();

                return dtauto;
            }
            catch (Exception g)
            {
                MessageBox.Show("erro autodao" + g);
                return null;
            }


            //in nome varchar(64), in ano_fab integer, in cor varchar(64), in km 
            //int, in valor int, in stat varchar(60), in marca int, in modelo int
        }

        #endregion

        #region cadastro veiculo
        public void cadastra_veiculo(Automovel a)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_cadastra_automovel", conexao);
                cmd.Parameters.AddWithValue("nome", a.auto_nome);
                cmd.Parameters.AddWithValue("ano_fab", a.auto_ano_fab);
                cmd.Parameters.AddWithValue("cor", a.auto_cor);
                cmd.Parameters.AddWithValue("km", a.auto_km);
                cmd.Parameters.AddWithValue("valor", a.auto_valor_d);
                cmd.Parameters.AddWithValue("stat", a.auto_status);

                cmd.Parameters.AddWithValue("marca", a.marca_id);
                cmd.Parameters.AddWithValue("modelo", a.modelo_id);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();


            }
            catch (Exception g)
            {
                MessageBox.Show("erro autodao" + g);
            }


            //in nome varchar(64), in ano_fab integer, in cor varchar(64), in km 
            //int, in valor int, in stat varchar(60), in marca int, in modelo int
        }
        #endregion
        #region altera veiculo
        public void altera_veiculo(Automovel a)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_altera_automovel", conexao);
                cmd.Parameters.AddWithValue("id", a.auto_id);

                cmd.Parameters.AddWithValue("nome", a.auto_nome);
                cmd.Parameters.AddWithValue("ano_fab", a.auto_ano_fab);
                cmd.Parameters.AddWithValue("cor", a.auto_cor);
                cmd.Parameters.AddWithValue("km", a.auto_km);
                cmd.Parameters.AddWithValue("valor", a.auto_valor_d);
                cmd.Parameters.AddWithValue("stat", a.auto_status);

                cmd.Parameters.AddWithValue("marca", a.marca_id);
                cmd.Parameters.AddWithValue("modelo", a.modelo_id);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();


            }
            catch (Exception g)
            {
                MessageBox.Show("erro autodao" + g);
            }


            //in nome varchar(64), in ano_fab integer, in cor varchar(64), in km 
            //int, in valor int, in stat varchar(60), in marca int, in modelo int
        }
        #endregion
        #region busca
        public DataTable busca(Automovel a)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_busca_auto", conexao);
                cmd.Parameters.AddWithValue("nome", a.auto_nome);
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
        #region exclui
        public void exclui_auto(Automovel a)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleta_automovel", conexao);
                cmd.Parameters.AddWithValue("id", a.auto_id);

                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro VERIFIQUE SE HÁ UMA LOCAÇÃO COM ESTE AUTOMÓVEL. ERRO:    " + e);
            }
        }
        #endregion
    }
}
