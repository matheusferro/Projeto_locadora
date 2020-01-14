using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class ClienteDAO
    {
        private readonly MySqlConnection conexao;
        public ClienteDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        public DataTable mostra_cliente()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_mostra_cliente", conexao)
                {
                    CommandType = CommandType.StoredProcedure
                };

                conexao.Open();

                DataTable tb_cliente = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tb_cliente);

                conexao.Close();
                return tb_cliente;

            }
            catch (Exception e)
            {
                MessageBox.Show("aaaaaaaaaa" + e);
                return null;
            }
        }

        #region busca
        public DataTable busca(Cliente c)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_busca_cliente",conexao);
                cmd.Parameters.AddWithValue("nome", c.cliente_nome);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                
                conexao.Close();
                return dt;
            }
            catch (Exception g)
            {
                MessageBox.Show(g+"");
                return null;
            }
        }

        #endregion
        #region cadastro 
        public void cadastro_cliente(Cliente c)
        {

                MySqlCommand cmd = new MySqlCommand("sp_cadastra_cliente", conexao);
                cmd.Parameters.AddWithValue("nome", c.cliente_nome);
                cmd.Parameters.AddWithValue("telefone", c.cliente_tel);
                cmd.Parameters.AddWithValue("sexo", c.cliente_sexo);
                cmd.Parameters.AddWithValue("email", c.cliente_email);
                cmd.Parameters.AddWithValue("endereco", c.cliente_nome);
                cmd.Parameters.AddWithValue("complemento", c.cliente_complemento);
                cmd.Parameters.AddWithValue("bairro", c.cliente_bairro);
                cmd.Parameters.AddWithValue("cidade", c.cliente_cidade);
                cmd.Parameters.AddWithValue("uf", c.cliente_uf);
                cmd.Parameters.AddWithValue("dt_nascimento", c.cliente_dt_nasc);
                cmd.Parameters.AddWithValue("dt_cadastro", c.cliente_dt_cad);
                cmd.Parameters.Add(new MySqlParameter("resposta", MySqlDbType.VarChar));
                cmd.Parameters["resposta"].Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();
            string r = (string)cmd.Parameters["resposta"].Value;
            MessageBox.Show(r);
                conexao.Close();

        }
        #endregion

        #region alterar 
        public void altera_cliente(Cliente c)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_altera_cliente", conexao);
                cmd.Parameters.AddWithValue("id", c.cliente_id);
                cmd.Parameters.AddWithValue("nome", c.cliente_nome);
                cmd.Parameters.AddWithValue("telefone", c.cliente_tel);
                cmd.Parameters.AddWithValue("sexo", c.cliente_sexo);
                cmd.Parameters.AddWithValue("email", c.cliente_email);
                cmd.Parameters.AddWithValue("endereco", c.cliente_nome);
                cmd.Parameters.AddWithValue("complemento", c.cliente_complemento);
                cmd.Parameters.AddWithValue("bairro", c.cliente_bairro);
                cmd.Parameters.AddWithValue("cidade", c.cliente_cidade);
                cmd.Parameters.AddWithValue("uf", c.cliente_uf);
                cmd.Parameters.AddWithValue("dt_nascimento", c.cliente_dt_nasc);
                cmd.Parameters.AddWithValue("dt_cadastro", c.cliente_dt_cad);
                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Complete os cmapos corretamente");
            }

        }
        #endregion

        #region exclui 
        public void deleta_cliente(Cliente c)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_deleta_cliente", conexao);
                cmd.Parameters.AddWithValue("id", c.cliente_id);

                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception)
            {

            }

        }
        #endregion
    }
}
