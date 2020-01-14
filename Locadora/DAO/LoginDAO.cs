using Locadora.Conexao;
using Locadora.Controle;
using Locadora.View;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Locadora.DAO
{
    internal class LoginDAO
    {
        private readonly MySqlConnection conexao;

        public LoginDAO()
        {
            conexao = ConnectionFactory.getConnection();
        }


        public void login(string login, string senha, Frm_login fg)
        {
            try
            {
                Form1 frm = new Form1();
                uc_automovel uc_auto = new uc_automovel();
                uc_cargo uc_cargo = new uc_cargo();
                uc_cliente uc_cl = new uc_cliente();
                uc_funcionario uc_func = new uc_funcionario();
                uc_locacao uc_loc = new uc_locacao();
                uc_marca uc_marc = new uc_marca();
                uc_modelo uc_mod = new uc_modelo();
                Login lg = new Login();
                MySqlCommand cmd = new MySqlCommand("sp_login", conexao);

                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("senha", senha);
                cmd.CommandType = CommandType.StoredProcedure;
                conexao.Open();
                cmd.ExecuteNonQuery();
                MySqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    string tipo = dtr.GetString("tb_usuario_tipo");
                    if (tipo.Equals("Gerente"))
                    {

                        frm.lbl_id.Text = dtr.GetString("tb_usuario_id");
                        frm.lbl_usuario.Text = dtr.GetString("tb_usuario_email");
                        frm.lbl_tipo.Text = tipo;
                        
                        frm.Show();
                        fg.Hide();

                    }
                    else if (tipo.Equals("Vendedor"))
                    {

                        frm.lbl_id.Text = dtr.GetString("tb_usuario_id");
                        frm.lbl_usuario.Text = dtr.GetString("tb_usuario_email");
                        frm.lbl_tipo.Text = tipo;
                        //permissoes
                        frm.btn_usuario_panel.Enabled = false;

                        uc_auto.btn_exclui_veiculo.Enabled = false;
                        uc_cargo.btn_exclui_cargo.Enabled = false;
                        uc_cl.btn_exclui.Enabled = false;
                        uc_func.btn_exclui_funcionario.Enabled = false;
                        uc_loc.button3.Enabled = false;
                        uc_marc.btn_exclui_marca.Enabled = false;
                        uc_mod.btn_exclui_modelo.Enabled = false;

                        frm.Show();
                        fg.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Verifique se os campos foram digitados corretamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique se os campos foram digitados corretamente !!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro (logindao).");
            }
        }

        public void up_img(Login lg)
        {
            byte[] img = lg.ms.ToArray();
            MySqlCommand cmd = new MySqlCommand(@"sp_altera_imagem", conexao);
            cmd.Parameters.AddWithValue("id", lg.id);
            cmd.Parameters.AddWithValue("img", img);
            cmd.CommandType = CommandType.StoredProcedure;
            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public MemoryStream set_img(Login lg)
        {
            try
            {
               
                MySqlCommand cmd = new MySqlCommand(@"sp_busca_imagem", conexao);
                cmd.Parameters.AddWithValue("id", lg.id);
                cmd.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conexao.Close();
                byte[] img = (byte[])(dt.Rows[0][0]);
                MemoryStream ms = new MemoryStream(img);
                return ms;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
