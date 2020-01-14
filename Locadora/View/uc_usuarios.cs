using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_usuarios : UserControl
    {
        public uc_usuarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o usuario de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
           , "EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                usuario u = new usuario
                {
                    id = (int)dataGridView1.CurrentRow.Cells[0].Value
                };
                usuarioDAO obju = new usuarioDAO();
                obju.exclui(u);
                uc_usuarios_Load(null, null);
            }
            else
            {
                MessageBox.Show("Exclusão cancelada !");
            }
        }


        public bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(cb_tipo.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                usuarioDAO udao = new usuarioDAO();
                dataGridView1.DataSource = udao.lista();
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaCampos())
                {
                    usuario u = new usuario
                    {
                        id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                        user = txt_user.Text,
                        senha = txt_senha.Text,
                        tipo = cb_tipo.Text
                    };
                    usuarioDAO udao = new usuarioDAO();
                    udao.altera(u);
                    uc_usuarios_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaCampos())
                {
                    usuario u = new usuario
                    {
                        user = txt_user.Text,
                        senha = txt_senha.Text,
                        tipo = cb_tipo.Text
                    };
                    usuarioDAO udao = new usuarioDAO();
                    udao.cadastra(u);
                    uc_usuarios_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_senha.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_user.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_tipo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void Txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.UseSystemPasswordChar = true;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_senha.UseSystemPasswordChar)
            {
                txt_senha.UseSystemPasswordChar = false;
            }
            else
            {
                txt_senha.UseSystemPasswordChar = true;
            }

        }
    }
}
