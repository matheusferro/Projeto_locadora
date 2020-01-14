using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class LocacaoDAO
    {
        private readonly MySqlConnection conexao;
        public LocacaoDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        #region mostra 
        public DataTable lista_locacao()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_mostra_locacao", conexao)
                {
                    CommandType = CommandType.StoredProcedure
                };
                conexao.Open();
                cmd.ExecuteNonQuery();

                DataTable dtloc = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dtloc);

                conexao.Close();

                return dtloc;
            }
            catch (Exception g)
            {
                MessageBox.Show("erro locacaodao" + g);
                return null;
            }
        }

        #endregion

        #region cadastro
        public void cadastra_locacao(Locacao l)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_cadastra_locacao", conexao);
                cmd.Parameters.AddWithValue("tipo", l.locacao_tipo);
                cmd.Parameters.AddWithValue("valor", l.locacao_valor);
                cmd.Parameters.AddWithValue("dt_inicio", l.locacao_dt_inicio);
                cmd.Parameters.AddWithValue("dt_fim", l.locacao_dt_fim);
                cmd.Parameters.AddWithValue("id_cliente", l.cliente);
                cmd.Parameters.AddWithValue("id_funcionario", l.funcionario);
                cmd.Parameters.AddWithValue("id_auto", l.automovel);

                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastrado");
            }
            catch (Exception g)
            {
                MessageBox.Show("erro autodao" + g);
            }
            //in tipo varchar(64), in valor int, in dt_inicio datetime, in dt_fim datetime,
            //    in id_cliente int, in id_funcionario int, in id_auto int
        }
        #endregion

        #region Alterar
        public void altera(Locacao l)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_altera_locacao", conexao);
                cmd.Parameters.AddWithValue("@id", l.locacao_id);
                cmd.Parameters.AddWithValue("@tipo", l.locacao_tipo);
                cmd.Parameters.AddWithValue("@valor", l.locacao_valor);
                cmd.Parameters.AddWithValue("@dt_inicio", l.locacao_dt_inicio);
                cmd.Parameters.AddWithValue("@dt_fim", l.locacao_dt_fim);

                cmd.Parameters.AddWithValue("@cliente_id", l.cliente);
                cmd.Parameters.AddWithValue("@funcionario_id", l.funcionario);
                cmd.Parameters.AddWithValue("@auto_id", l.automovel);
                cmd.CommandType = CommandType.StoredProcedure;


                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alterado");
                conexao.Close();
            }
            catch (Exception p)
            {
                MessageBox.Show("Erro alteradao" + p);
            }

        }
        #endregion

        #region Exclusao

        public void exclui(Locacao l)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleta_locacao", conexao);
                cmd.Parameters.AddWithValue("@id", l.locacao_id);

                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluído");
                conexao.Close();
            }
            catch (Exception q)
            {
                MessageBox.Show("Erro locacaodao" + q);
            }

        }
        #endregion
    }
}
