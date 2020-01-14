using Locadora.Conexao;
using Locadora.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class usuarioDAO
    {
        private readonly MySqlConnection conexao;
        public usuarioDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }

        #region lista
        public DataTable lista()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_mostra_user", conexao)
                {
                    CommandType = CommandType.StoredProcedure
                };
                conexao.Open();
                cmd.ExecuteNonQuery();

                DataTable dtuser = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dtuser);

                conexao.Close();

                return dtuser;
            }
            catch (Exception)
            { return null; }
        }
        #endregion

        #region cadastrar usuario
        public void cadastra(usuario u)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_cadastra_usuario", conexao);
                cmd.Parameters.AddWithValue("email", u.user);
                cmd.Parameters.AddWithValue("senha", u.senha);
                cmd.Parameters.AddWithValue("tipo", u.tipo);
                cmd.Parameters.Add(new MySqlParameter("?resultado", MySqlDbType.VarChar));
                cmd.Parameters["?resultado"].Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                string r = (string)cmd.Parameters["?resultado"].Value;
                MessageBox.Show(r);
                conexao.Close();

                //FUNCIONA MAS NAO É FUNCIONAL PORQUE A MENSAGEM VEM DO BANCO
                //if (r.Equals("cadastrado"))
                //{
                //    MessageBox.Show("Novo usuário cadastrado");
                //}
                //else if (r.Equals("erro"))
                //{
                //    MessageBox.Show("Email já existente");
                //}
                //else
                //{
                //    MessageBox.Show("Deu muito ruim");
                //}

                //TENTATIVAS FALHAS
                //MySqlDataReader dtr = cmd.ExecuteReader();
                //if (dtr.Read())
                //{
                //    MessageBox.Show("eroooooooooooooooooooo");
                //}
                //else
                //{
                //    MessageBox.Show("yess");
                //}


                //string dtr = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(dtr+"");
                //if (dtr.Read())
                //{
                //    string e = dtr.GetString("mensagem");
                //    MessageBox.Show(e.ToString());

                //    if (e.Equals("erro"))
                //    {
                //        MessageBox.Show("ERRO");
                //    }
                //    else if (e.Equals("Cadastrado com sucesso !")) 
                //    {
                //        MessageBox.Show("cadastrado com sucesso");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("usuario cadastrado !");
                //}
            }
            catch (Exception err)
            {
                MessageBox.Show("erro usuariodao.cadastrar" + err);
            }
        }

        #endregion

        #region alterar usuario
        public void altera(usuario u)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_altera_usuario", conexao);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@email", u.user);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@tipo", u.tipo);
                cmd.Parameters.Add(new MySqlParameter("?resultado", MySqlDbType.VarChar));
                cmd.Parameters["?resultado"].Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                string r = (string)cmd.Parameters["?resultado"].Value;
                MessageBox.Show(r);
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erro usuariodao.alterar");
            }
        }

        #endregion

        #region exclui usuario
        public void exclui(usuario u)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_exclui_usuario", conexao);
                cmd.Parameters.AddWithValue("@id", u.id);

                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("usuario excluído !");
                conexao.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erro usuariodao.excluir");
            }
        }

        #endregion





    }
}
